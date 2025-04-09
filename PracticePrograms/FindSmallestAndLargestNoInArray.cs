using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class FindSmallestAndLargestNoInArray
    {
        public void smallestLargestNumber()
        {
            int[] a = { 1, 2, 3, 6, 5 ,100};
            int min = a[0];
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i]<min)
                {
                    min = a[i];
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
        Console.WriteLine("Min num is : "+min + " max num is: " + max);
        }

    }
}
