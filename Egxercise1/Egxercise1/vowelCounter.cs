using System;

namespace Egxercise1
{
    public class vowelCounter
    {
        public static void countVowels()
        {
            Console.Write("Enter the words: ");
            var word = Console.ReadLine().Trim().ToLower();
            var buffer_word = "aeiou";
            int vowel_count = 0;

            if (!string.IsNullOrEmpty(word))
            {
                foreach (var letter in word)
                {
                    if (buffer_word.Contains(letter.ToString()))
                    {
                        vowel_count += 1;
                    }
                }
                Console.WriteLine($"Vowel count is: {vowel_count}");
            }
            else
            {
                Console.WriteLine("Please enter a valid string.");
            }
        }
    }
}
