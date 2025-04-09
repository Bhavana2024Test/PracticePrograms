using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class CountOfDuplicateNumber
    {
        public void duplicateNUmberCount()
        {
            int[] a = { 1, 2, 3, 1 ,2,3,2,4};
            int count;
            for (int i = 0; i < a.Length; i++)
            {
                count = 1;
                if (a[i] != -1)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[j] == a[i])
                        {
                            count++;
                            a[j] = -1;
                        }

                    }
                    if (count > 1)
                    {
                        Console.WriteLine(a[i] + ":" + count);
                    }
                }

            }
        }
    }
}
