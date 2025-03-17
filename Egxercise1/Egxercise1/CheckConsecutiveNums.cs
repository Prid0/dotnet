using System;
using System.Security.Cryptography;

namespace Egxercise1
{
    class CheckConsecutiveNums
    {
        public static void consecutivenums()
        {
            Console.WriteLine("enter the number seprated bt '-' ");
            string numbers = Console.ReadLine();
            var new_num = numbers.Split('-');
            int[] num_arr = new int[new_num.Length];


            for (int i = 0; i < new_num.Length; i++)
            {
                if (!int.TryParse(new_num[i], out num_arr[i]))
                {
                    Console.WriteLine("enter a valid input");
                    return;
                }
            }

            for (int i = 1; i < num_arr.Length; i++)
            {
                if ((num_arr[i] - num_arr[i - 1]) != 1)
                {
                    Console.WriteLine("Not Consecutive");
                    return;
                }
                
            }
            Console.WriteLine("Consecutive");

        }

    }
}
