using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class TwoStringsAreEqualOrNot
    {
        public void stringEqualOrNot()
        {
            string str1 = "hello";
            string str2 = "olleh";
            bool isEqual = true;
            if (str1.Length != str2.Length)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i]!= str2[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            if (isEqual == true) {
                Console.WriteLine("string is equal");
            }
            else
            {
                Console.WriteLine("string is not equal");
            }
        }
    }
}
