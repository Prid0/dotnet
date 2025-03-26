using System;

namespace InterfaceDemo
{
    public interface Icar
    {
        void engin(string name);
        void wheels();

    }

    public class mycar : Icar
    {
        public void engin(String name)
        {
            Console.WriteLine("every car has engin");
        }

        public void wheels()
        {
            Console.WriteLine("every car hav 4 wheels");
        }
    }

    public class mybike : Icar
    {
        public void engin(String name)
        {
            Console.WriteLine($"every {name} bike has engin");
        }
        public void wheels()
        {
            Console.WriteLine("every car hav 2 wheels");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Icar mybike = new mybike();
            mybike.engin("honda");
            mybike.wheels();
        }
    }
}
