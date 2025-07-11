using System;
namespace Rectangeprograme
{
    class Rectangleformula
    {
        public int Area(int l, int b)
        {

            Console.WriteLine("Area = " + l * b);
            return 0;
        }

        public int Perimeter(int l, int b)
        {
            Console.WriteLine("Perimeter  = " + 2 * (l * b));

            return 0;
        }

        public double diagonal(int l, int b)
        {
            double d = Math.Sqrt(l * l + b * b);

            Console.WriteLine("Diagonal = " + d);

            return 0;
        }
    }
    class Rectangle
    {
        static void Main()
        {
            int l, b;
            Console.WriteLine("Enter the Length = ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breath = ");
            b = Convert.ToInt32(Console.ReadLine());

            Rectangleformula obj = new Rectangleformula();

            obj.Area(l, b);
            obj.Perimeter(l, b);
            obj.diagonal(l, b);




        }
    }
}