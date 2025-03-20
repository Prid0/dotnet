using System;
using System.Collections.Generic;
namespace ListDemo
{

    class Program
    {
        static void Main()
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };


            numbers.Add(6);
            Console.WriteLine("After Add(6):");
            PrintList(numbers);

            // 2. Add multiple elements using AddRange
            numbers.AddRange(new List<int> { 7, 8, 9 });
            Console.WriteLine("After AddRange([7, 8, 9]):");
            PrintList(numbers);

            // 3. Remove an element
            numbers.Remove(4);
            Console.WriteLine("After Remove(4):");
            PrintList(numbers);

            // 4. Remove an element at a specific index
            numbers.RemoveAt(2);
            Console.WriteLine("After RemoveAt(2):");
            PrintList(numbers);

            // 5. Remove a range of elements
            numbers.RemoveRange(1, 3);
            Console.WriteLine("After RemoveRange(1, 3):");
            PrintList(numbers);

            // 6. Insert an element at a specific index
            numbers.Insert(2, 10);
            Console.WriteLine("After Insert(2, 10):");
            PrintList(numbers);

            // 7. Insert multiple elements at a specific index
            numbers.InsertRange(4, new List<int> { 11, 12 });
            Console.WriteLine("After InsertRange(4, [11, 12]):");
            PrintList(numbers);

            // 8. Sort the list in ascending order
            numbers.Sort();
            Console.WriteLine("After Sort():");
            PrintList(numbers);

            // 9. Convert the list to an array
            int[] array = numbers.ToArray();
            Console.WriteLine("List converted to Array:");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // 10. Find the first element that matches a condition
            int found = numbers.Find(x => x > 7);
            Console.WriteLine("Found element greater than 7: " + found);

            // 11. Find the index of the first element that matches a condition
            int index = numbers.FindIndex(x => x > 7);
            Console.WriteLine("Index of first element greater than 7: " + index);

            // 12. Find all elements that match a condition
            List<int> foundAll = numbers.FindAll(x => x > 7);
            Console.WriteLine("All elements greater than 7:");
            foreach (int item in foundAll)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // 13. Find the last element that matches a condition
            int lastFound = numbers.FindLast(x => x > 7);
            Console.WriteLine("Last element greater than 7: " + lastFound);

            // 14. Find the index of the last element that matches a condition
            int lastIndex = numbers.FindLastIndex(x => x > 7);
            Console.WriteLine("Index of last element greater than 7: " + lastIndex);

            // 15. Trim the excess capacity of the list
            numbers.TrimExcess();
            Console.WriteLine("After TrimExcess():");
            PrintList(numbers);

            // 16. Count the number of elements in the list
            Console.WriteLine("Count of elements in list: " + numbers.Count);
        }

        static void PrintList(List<int> numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }

}
