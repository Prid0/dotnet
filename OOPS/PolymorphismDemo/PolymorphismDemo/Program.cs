using System;

namespace PolymorphismDemo
{
    public class Animal
    {
        // Overridden method (for method overriding)
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }

        // Overloaded method (for method overloading)
        public void DisplayInfo(string info)
        {
            Console.WriteLine("Animal Info: " + info);
        }

        public void DisplayInfo(int number)
        {
            Console.WriteLine("Animal Number: " + number);
        }
    }

    // Derived class Dog
    public class Dog : Animal
    {
        // Method overriding
        public override void MakeSound()
        {
            Console.WriteLine("Bark! Bark!");
        }

        // Method overloading
        public void DisplayInfo(double weight)
        {
            Console.WriteLine("Dog weight: " + weight + " kg");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            animal.MakeSound();
            animal.DisplayInfo("Mammal");
            animal.DisplayInfo(10);

            Dog dog = new Dog();
            dog.MakeSound();
            dog.DisplayInfo("Friendly dog");
            dog.DisplayInfo(5);
            dog.DisplayInfo(15.5);

            Animal polyAnimal = new Dog();
            polyAnimal.MakeSound();

            Console.ReadKey();
        }
    }
}

