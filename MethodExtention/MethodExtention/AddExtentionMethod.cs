using System;

namespace MethodExtention
{
    static class AddExtentionMethod
    {
        public static void Func3(this Program p, string message)
        {
            Console.WriteLine($"this is func 3 : {message}");
        }

        public static int GreaterOrNot(int val1, int val)
        {
            return val > val1 ? val : val1;
        }
    }
}
