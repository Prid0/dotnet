using System;

namespace Egxercise1
{
    class reverseName
    {
        public static void reverse_string()
        {
            Console.Write("enter your name : ");
            var user_name = Console.ReadLine().Trim();
            var reverse_array = new string[user_name.Length];

            /*char[] charArray = user_name.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine("this is char array : " + string.Join("", (charArray)));*/

            for (int i = 0; i < user_name.Length; i++)
            {
                reverse_array[i] = user_name[user_name.Length - 1 - i].ToString();
            }

            Console.WriteLine($"reversed string is {string.Join("", reverse_array)}");
        }
    }
}
