using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class CountVowelsAndConsonant
    {
        public void VowelsConsonantCount()
        {
            string str = "hello world";
            int vowel = 0;
            int consonant = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i]== 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }
                if (str[i] == ' ')
                {
                    consonant--;
                }
            }
            Console.WriteLine(vowel);
            Console.WriteLine(consonant);
        }
    }
}
