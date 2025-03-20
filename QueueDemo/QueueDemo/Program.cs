using System;
using System.Collections;
//using System.Collections.Generic;
class Program
{

    static void Main()
    {

        //Queue<int> queue = new Queue<int>();
        Queue myqueue = new Queue();


        myqueue.Enqueue("amiit");
        myqueue.Enqueue(20);
        myqueue.Enqueue(30.44);
        myqueue.Enqueue(false);

        foreach (var ele in myqueue)
        {
            Console.WriteLine(ele);
        }
        Console.WriteLine();

        Console.WriteLine("Peek: " + myqueue.Peek());
        Console.WriteLine("Dequeue: " + myqueue.Dequeue());
        Console.WriteLine("Dequeue: " + myqueue.Dequeue());
        Console.WriteLine();

        foreach (var ele in myqueue)
        {
            Console.WriteLine(ele);
        }
        Console.WriteLine();

        Console.WriteLine("Contains 30: " + myqueue.Contains(20));
        Console.WriteLine("Queue count: " + myqueue.Count);

        myqueue.Clear();
        Console.WriteLine("Queue count after clear: " + myqueue.Count);

        //for converting it to array all the elements should be of same type
        //int[] array = myqueue.ToArray();
        //Console.WriteLine("Array contents: " + string.Join(", ", array));
    }
}
