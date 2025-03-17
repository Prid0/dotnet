using System;

namespace Egxercise1
{
    partial class Program
    {
        class CheckValidNumber
        {
            public static void CheckValidNum()
            {
                while (true)
                {
                    Console.Write("Enter a number between 1 and 10 (or type 'Exit' to stop): ");
                    string input = Console.ReadLine();

                    if (input.ToLower() == "exit")
                    {
                        Console.WriteLine("Thanks for using the program!");
                        break;
                    }

                    try
                    {
                        int number = Convert.ToInt32(input);

                        if (1 <= number && number <= 10)
                        {
                            Console.WriteLine($"{number} is a valid number.");
                        }
                        else
                        {
                            Console.WriteLine($"{number} is an invalid number.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
        }
    }
}
