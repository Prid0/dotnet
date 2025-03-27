using System;

namespace DelegatesDemo
{
    // Declare a delegate that takes a string message and returns void.
    public delegate void mydelegate(string message);

    // Declare a multi-delegate with no parameters and no return type.
    delegate void multiDelegate();

    class Program
    {
        // Method that matches the 'mydelegate' delegate, which takes a string message and prints it.
        public static void greet(string message)
        {
            Console.WriteLine($"This is your message: {message}\n");
        }

        public static void fun1()
        {
            Console.WriteLine("This is fun 1");
        }

        public static void fun2()
        {
            Console.WriteLine("This is fun 2");
        }

        public static void fun3()
        {
            Console.WriteLine("This is fun 3");
        }

        static void Main(string[] args)
        {
            // Create an instance of 'mydelegate' and assign it the method 'greet'
            mydelegate printmesg = new mydelegate(greet);
            printmesg("Hello!");

            // Declare four multi-delegate instances.
            multiDelegate del1, del2, del3, del4;

            del1 = new multiDelegate(fun1);
            del2 = new multiDelegate(fun2);
            del3 = new multiDelegate(fun3);

            // Combine the individual delegates into a multicast delegate 'del4'
            del4 = del2 + del3 + del1;

            // Invoke the multicast delegate, which calls all methods (fun1, fun2, and fun3) in sequence.
            del4();


            // Another way of Declare four multi-delegate instances.
            Console.WriteLine("Another way of Declare four multi-delegate instances.");
            multiDelegate del = new multiDelegate(fun1);
            del += fun2;
            del += fun3;
            del();

        }
    }
}
