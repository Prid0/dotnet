using System;
using System.Collections.Generic;

namespace Egxercise1
{
    class IsAnagram
    {

        public static void AreAnagrams(string str1, string str2)
        {
            // If the lengths of the strings are not equal, they can't be anagrams
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not a anagram!!");
            }

            // Create dictionaries to count the frequency of characters
            Dictionary<char, int> charCount1 = new Dictionary<char, int>();
            Dictionary<char, int> charCount2 = new Dictionary<char, int>();

            // Count characters in the first string
            foreach (char c in str1)
            {
                if (charCount1.ContainsKey(c))
                {
                    charCount1[c]++;
                }
                else
                {
                    charCount1[c] = 1;
                }
            }

            // Count characters in the second string
            foreach (char c in str2)
            {
                if (charCount2.ContainsKey(c))
                {
                    charCount2[c]++;
                }
                else
                {
                    charCount2[c] = 1;
                }
            }

            // Compare the two dictionaries
            foreach (var kvp in charCount1)
            {
                if (!charCount2.ContainsKey(kvp.Key) || charCount1[kvp.Key] != charCount2[kvp.Key])
                {
                    Console.WriteLine("Not an anagram!!");
                    return;
                }
            }


            Console.WriteLine("It is anagram!!");
        }
    }

}
