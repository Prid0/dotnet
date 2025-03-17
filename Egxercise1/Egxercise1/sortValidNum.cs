using System;
using System.Collections.Generic;

namespace Egxercise1
{
    class sortValidNum
    {
        public static void check_valid_number()
        {
            int len = 5;
            int num = len + 1;
            var num_list = new List<int>();
            while (len > 0)
            {
                Console.Write($"enter the {num - len} numer : ");
                int number = Convert.ToInt32(Console.ReadLine());
                if (!num_list.Contains(number))
                {
                    num_list.Add(number);
                    len -= 1;

                }
                else
                {
                    Console.WriteLine("please add new number");
                }
            }
            num_list.Sort();
            Console.WriteLine($"sorted numbers are :{string.Join(" ", num_list)}");
        }
    }
}
