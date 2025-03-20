using System;

namespace oopsConcept
{
    public class animal
    {
        public virtual void speacks()
        {
            Console.WriteLine("this is animal class");
        }

    }

    public class cat : animal
    {
        public override void speacks()
        {

            Console.WriteLine("this is cat class and override the base class");
        }
        public void sayname(string name)
        {
            Console.WriteLine("this is derived class " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            animal animal1 = new animal();
            animal1.speacks();

            Console.Write("enter your name : ");
            string username = Console.ReadLine();

            cat cat = new cat();
            cat.sayname(username);

            cat.speacks();
            Console.ReadLine()
            
        }
    }
}
