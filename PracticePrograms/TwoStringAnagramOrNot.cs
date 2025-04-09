using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class TwoStringAnagramOrNot
    {
        public void anagram()
        {
            string s1 = "listen", s2 = "silent";
            char[] a1= s1.ToCharArray();
            char[] a2= s2.ToCharArray();
            bool isequal = false;
            Array.Sort(a1);
            Array.Sort(a2);
            if (a1.Length != a2.Length)
            {
                isequal = false;
            }
            else
            {
                for (int i = 0; i < a1.Length; i++)
                {
                    if (a1[i] == a2[i])
                    {
                        isequal = true;
                    }
                    else
                    {
                        isequal = false;
                        break;
                    
                    }
                }
            }
            if (isequal)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("not a anagram");
            }
        }
    }
}
