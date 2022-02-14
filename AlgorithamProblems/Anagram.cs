using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithamProblems
{
    internal class Anagram
    {
        public void DisplayAnagram(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                Console.WriteLine("Lengtt of two strings are not same");
            }
            //Convert string to character array  
            char[] firstCharsArray = firstString.ToLower().ToCharArray();
            char[] secondCharsArray = secondString.ToLower().ToCharArray();
            //Sort array  
            Array.Sort(firstCharsArray);
            Array.Sort(secondCharsArray);
            //Check each character and position.  
            for (int i = 0; i < firstCharsArray.Length; i++)
            {
                if (firstCharsArray[i].ToString() != secondCharsArray[i].ToString())
                {
                    Console.WriteLine("Two strings are not anagram");
                }
            }
            Console.WriteLine("Two strings are anagram");

        }
    }
}
