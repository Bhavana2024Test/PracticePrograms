﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
           /* ReverseString sr1= new ReverseString();
            sr1.StringReverse();
            Console.WriteLine("---------------------------------------");
            ReverseSentence rc = new ReverseSentence();
            rc.SentenceReverse();
            Console.WriteLine("---------------------------------------");
            Palindrome p = new Palindrome();
            p.stringPalindrome();
            Console.WriteLine("---------------------------------------");
            ReverseNumberArray a= new ReverseNumberArray();
            a.ReverseNumberArray1();
           */ Console.WriteLine("---------------------------------------");
            FindDuplicateNUmbersInArray a2= new FindDuplicateNUmbersInArray();
            a2.dupicateNumberInArray();
            Console.WriteLine("---------------------------------------");
            //SortingAnArray s1 = new SortingAnArray();
            //s1.arraySorting();
           
           // Console.WriteLine("---------------------------------------");
           // SortArrayAnReverse a2 = new SortArrayAnReverse();
            //a2.ArraySortAndReverse();

           // Console.WriteLine("------------------------------------");
            FindSmallestAndLargestNoInArray a3= new FindSmallestAndLargestNoInArray();
            a3.smallestLargestNumber();

            Console.WriteLine("-------------------------------------");
            ReverseNumber r1= new ReverseNumber();
            r1.numberReverse();
            Console.WriteLine("-------------------------------------");
            SwapTwoNum s1 = new SwapTwoNum();
            s1.SwappingTwoNum();
            Console.WriteLine("-------------------------------------");
            CountVowelsAndConsonant cv1= new CountVowelsAndConsonant();
            cv1.VowelsConsonantCount();
            Console.WriteLine("-------------------------------------");
            FindCountOfDuplicateCharacterInString d1= new FindCountOfDuplicateCharacterInString();
            d1.duplicatecharcount();
            Console.WriteLine("-------------------------------------");
            LargestNumber l= new LargestNumber();
            l.FindLagestNumber();
            Console.WriteLine("-------------------------------------");
            EvenOddNoInArray e1= new EvenOddNoInArray();
            e1.EvenOddNo();

            Console.WriteLine("-----------------------------------------");
            SortAnArrayAnFindDuplicate s2 = new SortAnArrayAnFindDuplicate();
            s2.SortFindDuplicateArray();


            Console.WriteLine("-------------------------------------");
            DuplicateCharCount d2= new DuplicateCharCount();
            d2.CountOfDuplicateChar();

            Console.WriteLine("-------------------------------------");
            TwoStringsAreEqualOrNot ts= new TwoStringsAreEqualOrNot();
            ts.stringEqualOrNot();
            Console.WriteLine("-------------------------------------");
            TwoArrayIsEqualOrNot ta= new TwoArrayIsEqualOrNot();
            ta.twoArrayIsEqualOrNot();
            Console.WriteLine("-------------------------------------");
            NumberIsPalidrome np = new NumberIsPalidrome();
            np.PalindromeNumber();
            Console.WriteLine("-------------------------------------");
            CountOfDuplicateNumber c = new CountOfDuplicateNumber();
            c.duplicateNUmberCount();
           /* Console.WriteLine("-------------------------------------");
            lengthofLastWOrdFromString ls= new lengthofLastWOrdFromString();    
            ls.LastWordLength();
            Console.WriteLine("-------------------------------------");
            SecondLastWordLength sl= new SecondLastWordLength();
            sl.LengthSecondLastWord();*/
            Console.WriteLine("-------------------------------------");

            TwoStringAnagramOrNot anagramOrNot = new TwoStringAnagramOrNot();
            anagramOrNot.anagram();


        }
    }
    
}
