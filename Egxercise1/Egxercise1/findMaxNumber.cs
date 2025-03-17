using System;

namespace Egxercise1
{
    class findMaxNumber
    {
        public static void maxNumber()
        {
            Console.Write("enter 2 numbers seprated by space : ");
            var numbers = Console.ReadLine();
            string[] inputs = numbers.Split(' ');
            if (inputs.Length == 2)
            {
                try
                {
                    int num1 = Convert.ToInt32(inputs[0]);
                    int num2 = Convert.ToInt32(inputs[1]);
                    if (num1 > num2)
                    {
                        Console.WriteLine($"{num1} is the greater number");
                    }
                    else
                    {
                        Console.WriteLine($"{num2} is the greater number");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("enter the vaild input");
                }
            }

            else
            {
                Console.WriteLine("enter at least 2 number and not more then it!!");
            }

        }
    }
}

