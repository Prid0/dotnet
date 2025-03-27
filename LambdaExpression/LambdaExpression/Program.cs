using System;
using System.Linq;

namespace LambdaExpression
{
    // Declare a delegate that takes an integer and returns nothing (void)
    public delegate void Mydelegate(int a);

    class Program
    {
        static void Main(string[] args)
        {
            // Using an anonymous method with delegate
            Mydelegate obj2 = delegate (int a)
            {
                a += 20; 
                Console.WriteLine($"this by using the delegate method :{a}");  
            };
            obj2(3);  


            Mydelegate obj = (a) =>
            {
                a += 5;  
                Console.WriteLine($"this answer is from delegate lambda : {a}");
            };
            obj(70);  

            // Lambda expression shorthand version that calculates the square of a number
            Func<int, int> product = (a) => a * a;
            Console.WriteLine("product of given number is : " + product(3)); 

            // Action type lambda expression 
            Action<string> printMessage = (message) => Console.WriteLine($"Message from Action: {message}");

            printMessage("Hello from Action!");  

          
            int[] numbers = new int[7] { 1, 3, 2, 66, 4, 33, 32 };

            // Finding the maximum number in the array using LINQ
            int max_num = numbers.Max(x => x);  

            // Calculating the sum of all numbers in the array using LINQ Aggregate function
            int sum_of_num = numbers.Aggregate((x, y) => x + y); 

            // Finding the minimum number in the array using LINQ
            int min_num = numbers.Min(x => x);  

            // Squaring each number in the array using LINQ Select method
            var sqr_num = numbers.Select(x => x * x); 

            // Calculating the average of numbers in the array using LINQ
            double avg_num = numbers.Average(x => x); 

            // Calculating the sum of all numbers in the array using LINQ Sum method
            int sum_numbers = numbers.Sum(x => x);  

            // Sorting the array in ascending order using LINQ OrderBy
            var ascending = numbers.OrderBy(x => x); 

            // Sorting the array in descending order using LINQ OrderByDescending
            var descending = numbers.OrderByDescending(x => x); 

            // Filtering the array to get numbers less than 8 using LINQ Where
            var less_than = numbers.Where(x => x < 8);  

            // Counting how many numbers are even in the array using LINQ Count
            var num_countg = numbers.Count(x => x % 2 == 0); 

            // Removing duplicate numbers using LINQ Distinct method
            var distinct = numbers.Distinct();  

            // Taking the first 3 numbers from the array using LINQ Take method
            var take_num = numbers.Take(3);  

            // Skipping the first 2 numbers and taking the rest using LINQ Skip method
            var skip_num = numbers.Skip(2);

            // Printing the results of the various LINQ operations
            Console.WriteLine($"Max number is {max_num}");
            Console.WriteLine($"Sum of numbers is {sum_of_num}");
            Console.WriteLine($"Min number is {min_num}");

            Console.Write("Squared numbers are: ");
            foreach (var num in sqr_num)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.WriteLine($"Average of given numbers is {avg_num}");

            Console.WriteLine($"Sum of all numbers is {sum_numbers}");

            Console.Write("Ascending order: ");
            foreach (var num in ascending)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.Write("Descending order: ");
            foreach (var num in descending)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.Write("Numbers less than 8: ");
            foreach (var num in less_than)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.WriteLine($"Count of even numbers: {num_countg}");

            Console.Write("Distinct numbers: ");
            foreach (var num in distinct)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.Write("Take first 3 numbers: ");
            foreach (var num in take_num)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();

            Console.Write("Skip first 2 numbers: ");
            foreach (var num in skip_num)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();


            Console.ReadLine();  
        }
    }
}
