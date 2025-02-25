using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
     public class SortAnArrayAnFindDuplicate
    {
        public void SortFindDuplicateArray()
        {
            int[] a = { 1, 5, 1, 3, 2, 5, 4 };
            int temp=0;
            for (int i = 0; i < a.Length; i++)
            {   for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i]> a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                    
                }
               ///Console.WriteLine(a[i]);//sorted array here
               
                for (int l = i + 1; l < a.Length; l++)
                {
                    if (a[l] == a[i])
                    {
                        Console.Write(a[l] + ", ");// duplicate elements here
                    }
                }
            }
            

        }
    }
}
