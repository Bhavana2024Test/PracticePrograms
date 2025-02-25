using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class Palindrome
    {
        public void stringPalindrome()
        {
            string str = "madam";
            string rev = "";
            for (int i = 0; i < str.Length; i++)
            {
                rev = str[i] + rev;
            }
            if (str.Equals(rev))
            {
                Console.WriteLine("Palindrome");

            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
