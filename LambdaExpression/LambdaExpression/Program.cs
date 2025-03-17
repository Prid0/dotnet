using System;

namespace LambdaExpression
{
    // Declare a delegate that takes an integer and returns nothing (void)
    public delegate void Mydelegate(int a);

    class Program
    {
        static void Main(string[] args)
        {
            // Using an anonymous method with delegate to add 20 to the input value
            Mydelegate obj2 = delegate (int a)
            {
                a += 20;
                Console.WriteLine($"this by using the delegate method :{a}");
            };
            obj2(3);

            // Using a lambda expression to add 5 to the input value and print it
            Mydelegate obj = (a) =>
            {
                a += 5;
                Console.WriteLine($"this answer is from delegate lambda : {a}");
            };
            obj(70);

            // Lambda expression shorthand version that calculates the square of a number
            Func<int, int> product = (a) => a * a;

            // Printing the result of the square calculation
            Console.WriteLine("product of given number is : " + product(3));

            // Action type lambda expression that prints a message without returning a value
            Action<string> printMessage = (message) => Console.WriteLine($"Message from Action: {message}");

            // Calling the Action lambda expression
            printMessage("Hello from Action!");

            Console.ReadLine();
        }
    }
}
