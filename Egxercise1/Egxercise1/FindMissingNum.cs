using System;
using System.Collections.Generic;
using System.Linq;

namespace Egxercise1
{
    class FindMissingNum
    {
        public static void missingNum(int[] arr)
        {
            List<int> missingNum = new List<int>();
            Array.Sort(arr);
            int maxNum = arr[arr.Length - 1];

            Console.WriteLine($"Array length: {arr.Length}");

            for (int i = arr[0]; i <= maxNum; i++)
            {

                if (!arr.Contains(i))
                {
                    missingNum.Add(i);
                }
            }

            // Print the missing numbers
            foreach (var num in missingNum)
            {
                Console.Write(num + " ");
            }
        }
    }
}
