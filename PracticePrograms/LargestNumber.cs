using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class LargestNumber
    {
        public void FindLagestNumber()
        {
            int a = 5, b = 10;
            int c;
            c = a > b ? a : b;//wihtout using if else condition
            Console.WriteLine(c);


            if (a > b)
            {
                Console.WriteLine("a is largest:"+a);
            }
            else
            {
                Console.WriteLine("b is largest:" + b);
            }

        }
    }
}
