using System;

namespace MethodExtention
{
    class Animal
    {
        public void Legs(string Aname)
        {
            Console.WriteLine($"{Aname} walks on 4 legs");
        }
        public virtual void speaks()
        {
            Console.WriteLine("this is animal class");
        }
    }

    class Dog : Animal
    {
        public override void speaks()
        {
            Console.WriteLine("tghis is from Don class");
        }
    }



    class Program
    {
        public void Func1()
        {
            Console.WriteLine("this is func 1");
        }
        public void Func2()
        {
            Console.WriteLine("this is func 2");
        }
        static void Main(string[] args)
        {
            //Animal obj1 = new Animal();
            //obj1.Legs("dog");
            //obj1.speaks();

            //Dog ob2 = new Dog();
            //ob2.speaks();
            //ob2.Legs("cat");
            Console.WriteLine("thi sis from program side ");
            Program p = new Program();
            p.Func1();
            p.Func2();



        }
    }
}
