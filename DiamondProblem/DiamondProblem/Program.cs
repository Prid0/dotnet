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


    // Class ID implements both IC and IA interfaces
    // Also handles Ambiguity by explicitly defining the IC and IA
    class ID : IC, IA
    {
        // Explicit interface implementation for IC
        void IC.show()
        {
            Console.WriteLine("Hello from IC");
        }

        // Explicit interface implementation for IA
        void IA.show()
        {
            Console.WriteLine("Hello from IA");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of ID class
            ID obj = new ID();

            // Casting the object to IC and calling show() from IC
            ((IC)obj).show();

            // Casting the object to IA and calling show() from IA
            ((IA)obj).show();

            //OR
            IC ic = new ID();
            ic.show();

            Console.ReadKey();
        }
    }
}
