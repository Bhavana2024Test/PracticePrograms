﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class DuplicateCharCount
    {
        public void CountOfDuplicateChar()
        {
            string str = "thisisprogram";
            int count = 0;
           
            for (int i = 0; i < str.Length; i++)
            {
                for(int j = i+1; j < str.Length; j++) 
                    {
                        if (str[i] == str[j]) 
                            {
                                count++;
                        Console.Write(str[i]+", ");
                            }
                    }
               
            }
            
            Console.WriteLine("count is: "+count);
        }
    }
}
