﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class ReverseNumber
    {
        public void numberReverse()
        {
            int num = 123;
            int rev = 0;
            while(num!=0)
            {
                int rem = num % 10;
                rev = rev * 10 + rem;
                num=num / 10;   

            }
            Console.WriteLine(rev); 

        }
    }
}
