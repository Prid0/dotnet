using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadingDemo
{
    class Program
    {
        public static void func1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"func1 : {i}");
                if (i == 25)
                {
                    Console.WriteLine("func1 is on sleep for 8 sec");
                    Thread.Sleep(8000);
                }
            }
            Console.WriteLine("func1 completed!!!");
        }

        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"func2 : {i}");
            }
            Console.WriteLine("func2 completed!!!");
        }
        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"func3 : {i}");
            }
            Console.WriteLine("func3 completed!!!");
        }


        //Task
        static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Number: {i}");
                Task.Delay(500).Wait();
            }
        }
        static void Main(string[] args)
        {
            //Thread ti = Thread.CurrentThread;
            //ti.Name = "demo-thread-1";
            //Console.WriteLine(Thread.CurrentThread.Name);

            //Program.func1();
            //Program.func2();
            //Program.func3();

            Thread t1 = new Thread(func1);
            Thread t2 = new Thread(func2);
            Thread t3 = new Thread(func3);

            //t1.Start();
            //t3.Start();
            //t2.Start();

            //task: The Task class from the Task Parallel Library (TPL)
            Console.WriteLine("current thgread name is : " + Thread.CurrentThread.Name);
            Task mytask = Task.Run(() => PrintNumbers());
            mytask.Wait();


            //Parallel.For() splits the loop into multiple tasks, running each iteration concurrently on different threads from the thread pool.
            //Parallel.foreach is Similar to Parallel.For(),it allows you to run a loop in parallel, but it works with collections(like arrays or lists).
            Parallel.For(0, 5, i =>
            {

                Console.WriteLine($"Parallel Task {i} is running on thread {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            });

            //This method allows you to execute multiple independent tasks in parallel.It takes a list of actions and executes them concurrently.
            Console.WriteLine("this is parallel invoke");
            Parallel.Invoke(() => func1(),
                () => func2(),
                () => func3());

            Console.WriteLine("Main thread ends.");
        }
    }
}
