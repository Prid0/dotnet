using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace IenumerableAndIenumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(21);
            numbers.Add(23);
            numbers.Add(24);
            numbers.Add(25);
            numbers.Add(26);
            numbers.Add(28);

            IEnumerable<int> Ienum = (IEnumerable<int>)numbers;

            //var num = Ienum.GetEnumerator();
            //while (num.MoveNext())
            //{
            //    Console.WriteLine(num.Current);
            //}
            //foreach (var item in Ienum)
            //{
            //    Console.WriteLine(item);
            //}

            IEnumerator<int> Ienumarat = numbers.GetEnumerator();
            //printfrom1to4(Ienumarat);
            while (Ienumarat.MoveNext())
            {
                Console.WriteLine(Ienumarat.Current);
            }
            Console.ReadKey();

        }

        static void printfrom1to4(IEnumerator<int> list)
        {
            while (list.MoveNext())
            {
                Console.WriteLine(list.Current.ToString());
                if (Convert.ToInt32(list.Current) >= 24)
                {
                    printafter4(list);
                }

            }
        }
        
        static void printafter4(IEnumerator<int> list)
        {
            while (list.MoveNext())
            {
                Console.WriteLine("after4 : " + list.Current.ToString());
            }
        }
        
       
    }
}
