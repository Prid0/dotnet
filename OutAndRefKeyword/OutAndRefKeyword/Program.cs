using System;

namespace OutAndRefKeyword
{
    class Program
    {
        static void incrementMethod(out int inverVal)
        {
            inverVal = 0;
            inverVal += 10;
        }
        //}static void incrementMethod(ref int inverVal)
        //{
        //    inverVal += 10;
        //}

        static void Main(string[] args)
        {
            int outerval = 20;
            //incrementMethod(ref outerval);
            incrementMethod(out outerval);
            Console.WriteLine(outerval);
        }
    }
}
