using System;

namespace MethodExtention
{
    class CallExtendetMethod
    {
        static void Main()
        {
            Console.WriteLine("called from extended method");
            Program p = new Program();
            p.Func3("from extended side");
            p.Func1();
            p.Func2();

            var res = AddExtentionMethod.GreaterOrNot(6, 2);
            Console.WriteLine("res : " + res);

        }
    }
}
