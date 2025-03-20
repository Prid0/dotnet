using System;
using System.Collections.Generic;

namespace Egxercise1
{
    class FindMissingNum
    {
        public static void missingNum(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Array is empty.");
                return;
            }

            HashSet<int> numSet = new HashSet<int>(arr);
            List<int> missingNum = new List<int>();

            Array.Sort(arr);
            int maxNum = arr[arr.Length - 1];

            Console.WriteLine($"Array length: {arr.Length}");


            for (int i = arr[0]; i <= maxNum; i++)
            {
                if (!numSet.Contains(i))
                {
                    missingNum.Add(i);
                }
            }

            if (missingNum.Count > 0)
            {
                Console.WriteLine("Missing numbers: " + string.Join(" ", missingNum));
            }
            else
            {
                Console.WriteLine("No missing numbers.");
            }
        }
    }
}
