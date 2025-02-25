using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class ReverseNumberArray
    {
        public void ReverseNumberArray1()
        {
            int[] a = { 101, 102, 103, 104 };
            for (int i = a.Length-1;i>=0; i--)
            {
               Console.WriteLine(a[i]);
            }
        }
    }
}
