using System;

namespace Egxercise1
{
    class Textconverter
    {
        public static void textCapitalizer()
        {
            Console.Write("Enter the words: ");
            var words = Console.ReadLine().Trim();
            var splitWords = words.Split(' ');
            string finalwords = "";
            //Console.WriteLine(string.Join(" ", splitWords));
            foreach (string word in splitWords)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    string currentLetter = word[0].ToString();
                    finalwords += currentLetter.ToUpper() + word.Substring(1).ToLower() + " ";
                }
            }
            Console.Write("Capitalize string is: " + finalwords);
        }
    }
}
