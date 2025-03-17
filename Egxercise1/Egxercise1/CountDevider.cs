using System;

namespace Egxercise1
{
    class CountDevider
    {
        public static void deviderCounter()
        {
            int numCount = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    numCount += 1;
                }
            }
            Console.WriteLine($"there are {numCount} between 1 to 100 which are divided by 3");
        }
    }
}
