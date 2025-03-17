using System;

namespace Egxercise1
{
    class FactorialCalculator
    {
        public static void FactCalculate()
        {
            Console.Write("Enter the number to get the factorial: ");
            var num = Console.ReadLine();
            int fact_num = 1;

            if (int.TryParse(num, out int number))
            {
                for (int i = number; i > 0; i--)
                {
                    fact_num *= i;
                }

                Console.WriteLine($"Factorial of {number} is {fact_num}");

                Console.WriteLine("Enter 'OK' to try again, or any other key to exit.");
                var message = Console.ReadLine();
                if (message.ToLower() == "ok")
                {
                    FactCalculate();
                }
                else
                {
                    Console.WriteLine("Thanks for using!");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}
