using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class ReverseSentence
    {

        public void SentenceReverse() {
            string str = "This is program";
            string rev = "";
            string[] s = str.Split(" ");
            for (int i = 0; i < s.Length; i++)
            {
                rev = s[i] + " " + rev;
            }
            Console.WriteLine(rev);
        }
    }
}
