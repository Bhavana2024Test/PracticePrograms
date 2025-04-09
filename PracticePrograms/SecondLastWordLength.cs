using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class SecondLastWordLength
    {
        public void LengthSecondLastWord()
        {
            Console.WriteLine("enter the stentence");
            string sen = Console.ReadLine();

            string x = sen.Trim();
            int len = 0;
            int prev = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == ' ')
                {
                    prev = len;
                    len = 0;
                }
                else
                {
                    len++;
                }

            }
            Console.WriteLine("length of second last word is: "+prev);
        }
    }
}
