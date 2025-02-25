using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class FindCountOfDuplicateCharacterInString
    {
        public void duplicatecharcount()
        {
            string str = "hello";
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for(int j = i+1; j < str.Length; j++)
                {
                    if(str[j] == str[i])
                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
