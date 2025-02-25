using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticePrograms
{
    public class SortArrayAnReverse
    {
        public void ArraySortAndReverse()
        {
            int[] a = { 1, 5, 3, 2, 4, 1 };
            int temp = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine(a[i]);
                
            }
            Console.WriteLine("---------------------------------------");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
