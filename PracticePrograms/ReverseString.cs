using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class ReverseString 
    {

        public void StringReverse()
        {
            string str = "Hello World";
            string rev = "";
            for (int i = 0; i < str.Length; i++)
            {
                rev = str[i] + rev;
            }
            Console.WriteLine(rev);
          
        }
    }
}
