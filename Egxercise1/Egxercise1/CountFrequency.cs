using System;
using System.Collections.Generic;
using System.Linq;

namespace Egxercise1
{
    class CountFrequency
    {
        public static void CountFrq(string word)
        {
            word = word.ToLower().Trim();
            if (string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine("Please write something!!");
            }
            else
            {
                Dictionary<char, int> frqCount = new Dictionary<char, int>();

                // Count the frequency of each character in the string
                foreach (var ch in word)
                {
                    if (frqCount.ContainsKey(ch))
                    {
                        frqCount[ch] += 1;
                    }
                    else
                    {
                        frqCount[ch] = 1;
                    }
                }

                // Sort the dictionary by frequency in descending order
                var sortedFrq = frqCount.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

                // Print the sorted frequencies
                foreach (var pair in sortedFrq)
                {
                    Console.WriteLine($"Frequency of '{pair.Key}' is {pair.Value}");
                }

                Console.WriteLine("\n----Non-sorted-----");
                // Print the non-sorted frequencies
                foreach (var ch in frqCount.Keys)
                {
                    Console.WriteLine($"frequency of {ch} is {frqCount[ch]}");
                }
            }
            Console.WriteLine("Thanks for using!!");
        }
    }

}

