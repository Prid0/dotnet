using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace StringAndStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "1 ";

            for (int i = 2; i <= 100; i++)
            {
                numbers += i + " ";
            }

            foreach (var item in numbers)
            {
                Console.Write(item);
                
            }

            StringBuilder sb = new StringBuilder("Hello World");

            sb.Append("! How are you?");
            Console.WriteLine("After Append: " + sb.ToString());

            sb.Insert(6, "Beautiful ");
            Console.WriteLine("After Insert: " + sb.ToString());

            sb.Replace("Beautiful", "Amazing");
            Console.WriteLine("After Replace: " + sb.ToString());

            sb.Remove(6, 8);  
            Console.WriteLine("After Remove: " + sb.ToString());

            // AppendLine: Adds a string with a newline at the end
            sb.AppendLine(" This is a new line.");
            Console.WriteLine("After AppendLine: " + sb.ToString());

            // Clear: Clears all the content in StringBuilder
            sb.Clear();
            Console.WriteLine("After Clear: " + sb.ToString());  

            // Reverse: Reverses the current content of the StringBuilder
            sb = new StringBuilder("Hello World");
            sb = new StringBuilder(new string(sb.ToString().Reverse().ToArray()));

            Console.WriteLine("After Reverse: " + sb.ToString());

            string result = sb.ToString();
            Console.WriteLine("After ToString: " + result);

            // Length: Gets the length of the current StringBuilder content
            Console.WriteLine("Length: " + sb.Length);

            Console.ReadLine();
            IEnumerable

        }
    }
}
