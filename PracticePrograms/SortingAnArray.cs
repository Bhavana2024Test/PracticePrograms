using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class SortingAnArray
    {
        public void arraySorting()
        {
            int[] a = { 1, 2, 5, 4, 3 };
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
                Console.Write(a[i]+", ");
            }
        }  
    }
}
