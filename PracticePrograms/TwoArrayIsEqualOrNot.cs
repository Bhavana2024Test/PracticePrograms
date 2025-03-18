using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class TwoArrayIsEqualOrNot
    {
        public void twoArrayIsEqualOrNot()
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 1, 2, 3};
            bool isEqual = true;
            if (a.Length != b.Length)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != b[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            if(isEqual)
            {
                Console.WriteLine("Array is Same");
            }
            else
            {
                Console.WriteLine("Array is not same");
            }
        }
        
    }
}
