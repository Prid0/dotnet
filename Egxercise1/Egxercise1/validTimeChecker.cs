using System;

namespace Egxercise1
{
    class validTimeChecker
    {
        public static void chekTheTime()
        {
            Console.WriteLine("enter the time in this formet '00:00' :");

            var time_input = Console.ReadLine();
            if (time_input != "")
            {

                var split_time = time_input.Split(':');
                var buffer_time = new int[split_time.Length];
                for (int i = 0; i < split_time.Length; i++)
                {
                    if (!int.TryParse(split_time[i], out buffer_time[i]))
                    {
                        Console.WriteLine("enter in vaild formet");
                        break;
                    }
                }
                if (buffer_time[0] < 24 && buffer_time[0] >= 0 && buffer_time[1] >= 0 && buffer_time[1] < 60)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
            else
            {
                Console.WriteLine("empty");
            }

        }
    }
}
