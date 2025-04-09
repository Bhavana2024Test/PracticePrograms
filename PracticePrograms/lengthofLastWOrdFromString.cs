using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class lengthofLastWOrdFromString
    {
        public void LastWordLength()
        {
            Console.WriteLine("enter the stentence");
            string sen=Console.ReadLine();

            string x = sen.Trim();
            int len = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if(x[i] == ' ') 
                    {
                        len = 0;
                    }
                else
                {
                    len++;
                }

            }
            Console.WriteLine("length of last word: "+len);
        }
    }
}
