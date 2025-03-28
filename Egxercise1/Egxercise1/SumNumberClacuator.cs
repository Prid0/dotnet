using System;

namespace Egxercise1
{
    class SumNumberClacuator
    {
        public static void SumCalculator()
        {
            Console.WriteLine("enter the number to sum and OK to exit ");
            int total = 0;
            while (true)
            {
                Console.Write("enter number here : ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    if (total == 0)
                    {
                    Console.WriteLine($"thanks for using!! but you did entered any number.");
                    }
                    else
                    {
                    Console.WriteLine($"thanks for using!! and your current num is :{total}");
                    break;
                    }
                }
                else
                {
                    try
                    {
                        int num = int.Parse(input);
                        total += num;
                        Console.WriteLine($"current total value is :{total}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("enter a valid num");
                    }

                }
            }
        }
    }
}
