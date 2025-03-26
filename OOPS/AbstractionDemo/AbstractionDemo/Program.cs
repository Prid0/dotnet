using System;

namespace AbstractionDemo
{
    public abstract class shape
    {
        public abstract void claculate();

        public void Done()
        {
            Console.WriteLine("calculation done!!");
        }

    }

    public class square : shape
    {
        public int side;
        public square(int s)
        {
            this.side = s;

        }
        public override void claculate()
        {
            double area = side * side;
            Console.WriteLine($"arear od square is {area}sqm");
        }

    }

    public class rect : shape
    {
        public double Rlength;
        public double Rhight;
        public rect(double h, double l)
        {
            this.Rhight = h;
            this.Rlength = l;
        }

        public override void claculate()
        {
            double area = Rlength * Rhight;
            Console.WriteLine($"area of rectriangle : {area}sqm");
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            shape square1 = new square(5);
            square1.claculate();
            square1.Done();
            shape rec1 = new rect(22, 32.4);
            rec1.claculate();
            rec1.Done();


        }
    }
}
