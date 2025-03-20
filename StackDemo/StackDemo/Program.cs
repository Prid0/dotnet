using System;
using System.Collections;

namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack mystack = new Stack();
            mystack.Push("amit");
            mystack.Push("rohit");
            mystack.Push(5.60);
            mystack.Push(null);
            mystack.Push(2434);
            mystack.Push(false);

            foreach (object items in mystack)
            {
                Console.WriteLine($"items are :{items}");
            }

            var ele = mystack.Pop();
            Console.WriteLine($"------poped-element-------: {ele}");
            foreach (object items in mystack)
            {
                Console.WriteLine($"items are :{items}");
            }

            Console.WriteLine("Top element: " + mystack.Peek());
            Console.WriteLine("Popped element: " + mystack.Pop());
            Console.WriteLine("Popped element: " + mystack.Pop());
            Console.WriteLine("Contains 5.60: " + mystack.Contains(5.60));
            Console.WriteLine("Stack count: " + mystack.Count);
            mystack.Clear();
            Console.WriteLine("Stack count after clear: " + mystack.Count);



        }
    }
}
