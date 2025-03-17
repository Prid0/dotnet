using System;

namespace Egxercise1
{
    class findMaxNumber2
    {
        public static void findMaxNum2()
        {
            Console.WriteLine("enter the series of number to find max number , seprated by ' ' space ");
            string inputs = Console.ReadLine();
            string[] number = inputs.Split(' ');
            int max_num = int.MinValue;
            foreach (string nums in number)
            {
                if (int.TryParse(nums, out int converted_num))
                {
                    if (max_num < converted_num)
                    {
                        max_num = converted_num;
                    }
                }
                else
                {
                    Console.WriteLine("enter a valod series of numbers");
                    break;
                }
            }
            Console.WriteLine($"max number from give series is {max_num}");
        }
    }
}
