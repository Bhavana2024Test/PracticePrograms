using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class EvenOddNoInArray
    {
        public void EvenOddNo()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7 };
            int even = 0;
            int odd = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] %2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Even count:" + even);
            Console.WriteLine("Odd Count:"+odd);

        }
    }
}
