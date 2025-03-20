using System;

namespace DiamondProblem
{
    public interface IA
    {
        void show();
    }
    public interface IB : IA
    {
        void show();
    }
    public interface IC : IA
    {
        void show();

    }
    class ID : IC, IA
    {
        public void show()
        {
            Console.WriteLine("hellow from D");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IA obj = new ID();
            obj.show();

        }
    }
}
