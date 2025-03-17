using System;

namespace Egxercise1
{
    class numberGussseingGame
    {
        public static void numberGame()
        {
            var random = new Random();
            int randomNum = random.Next(1, 10);
            Console.WriteLine("you have total 4 chance to paly");
            int chance = 4;
            int chance_count = 1;
            while (chance_count <= chance)
            {
                Console.Write($"this is your {chance_count} chance, enter your choise :");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int choise))
                {
                    if (choise == randomNum)
                    {
                        Console.WriteLine($"you won , the number was {randomNum} in {chance_count} chance");
                        break;
                    }
                    else
                    {
                        chance -= 1;
                        chance_count += 1;
                        Console.WriteLine($"wrong guess , chance left: {chance}");
                    }

                }
                else
                {
                    Console.WriteLine("enter a valid number!!");
                }

            }
            Console.WriteLine($"thanks for playing, the number was: {randomNum}");
        }
    }
}
