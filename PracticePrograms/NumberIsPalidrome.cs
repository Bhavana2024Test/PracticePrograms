using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class NumberIsPalidrome
    {
        public void PalindromeNumber()
        {
            int a = 121;
            int rev = 0;
            int num = a;
            while(a!=0)
            {
                int rem = a % 10;
                rev = rev * 10 + rem;
                a = a / 10;

            }
            if(num==rev)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("NOt a Palindrome");
            }
        }
    }
}
