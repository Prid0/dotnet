using System;

namespace NullableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable is a type that can store either a value (like a number or a boolean) or a null (which means "no value" or "undefined") for value types such as int, bool, and double. However, it is not needed for reference types like string, since reference types already support null values.

            Nullable<int> num1 = null;
            int? number = null;
            string nullAbleVal = "dgwdgweu";

            Console.WriteLine("nullable examples---->");
            Console.WriteLine(number);
            Console.WriteLine(nullAbleVal);

            if (num1.HasValue)
            {
                Console.WriteLine("numer is : " + num1);
            }
            else
            {
                Console.WriteLine("it has null val");
                Console.WriteLine("the defaul val is : " + number.GetValueOrDefault(100));
            }
        }
    }
}
