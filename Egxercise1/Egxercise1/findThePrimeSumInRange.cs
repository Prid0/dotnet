namespace Egxercise1
{

    class findThePrimeSumInRange
    {
        public static bool CheckPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i * i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static int numRange(int n)
        {
            int count = 0;
            int sum = 0;
            int num = 2;
            while (count < n)
            {
                if (CheckPrime(num))
                {
                    sum += num * num;
                    count++;
                }
                num++;
            }
            return sum;
        }

    }


}
