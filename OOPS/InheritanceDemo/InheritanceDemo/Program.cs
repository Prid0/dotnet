using System;

namespace InheritanceDemo
{
    public class animal
    {
        public string name { get; set; }
        public animal(string Name)
        {
            name = Name;
        }

        //public static void leng()
        //{
        //    Console.WriteLine($"{name} has 4 legs");
        //}

        public void leng()
        {
            Console.WriteLine($"{name} has 4 legs");
        }

        public void run()
        {
            Console.WriteLine($"{name} run very fast!!");
        }
    }

    public class Dog : animal
    {
        public Dog(string name) : base(name)
        {

        }

        public void myname()
        {
            Console.WriteLine($"hello iam {name} a dog");
        }

        public void run()
        {
            Console.WriteLine("this run is from dog class not from base class");
        }
    }

    public class Cat : animal
    {
        public Cat(string name) : base(name)
        {

        }
        public void greet()
        {
            Console.WriteLine($"hello iam {name} a cat");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Dog mydog = new Dog("dwed");
            mydog.run();
            mydog.myname();

            animal Dog = new Dog("mars");
            //this is Casting:
            ((Dog)Dog).myname();

            Dog.run();
            Dog.leng();

            ((Dog)Dog).run();

            animal myanimal = new animal("hello my making obj of base class animal");
            myanimal.leng();
        }
    }
}
