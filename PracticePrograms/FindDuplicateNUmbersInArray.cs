using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class FindDuplicateNUmbersInArray
    {
        public void dupicateNumberInArray()
        {
            int[] a = { 1, 2, 3, 1,2};
            
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                    {
                        
                        Console.Write(a[j]+", ");
                    }

                    
                }
                
            }
            
        }
    }
}
