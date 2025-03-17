using System;

namespace Egxercise1
{
    class SpeedLimitCheck
    {
        public static void speedLimit()
        {
            Console.Write("enter the speed limit : ");
            int speed_limit = int.Parse(Console.ReadLine());
            Console.Write("enter the speed of car :");
            int car_speed = int.Parse(Console.ReadLine());
            int demerit_point = 0;
            if (car_speed < speed_limit)
            {
                Console.WriteLine("ok!");
            }
            else
            {
                demerit_point = Math.Abs((car_speed-speed_limit) / 5);

                if (demerit_point > 12)
                {
                    Console.WriteLine($"License Suspended since your demerit is {demerit_point}");
                }
                else
                {
                    Console.WriteLine($"your currentg demerit point is {demerit_point} ");
                }
            }
        }
    }
}
