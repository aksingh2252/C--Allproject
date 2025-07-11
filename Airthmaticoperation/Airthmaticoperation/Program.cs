using System;
namespace AirthmaticPrograme
{
    public class Airthmatic
    {
        public int Addition(int a, int b)
        {
            return a + b;

        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public int Division(int a, int b)
        {
            return a / b;
        }
        public int Modulus(int a, int b)
        {
            return a % b;
        }
    }

    class Allfun
    {
        static void Main()
        {
            int a, b;
            Console.WriteLine("Enter the First Number = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number = ");
            b = Convert.ToInt32(Console.ReadLine());
            Airthmatic obj = new Airthmatic();
            Console.WriteLine("Addition = "+obj.Addition(a,b));
            Console.WriteLine("Subtraction = "+obj.Subtraction(a, b));
            Console.WriteLine("Multiplication = "+obj.Multiplication(a, b));
            Console.WriteLine("Division = "+obj.Division(a, b));
            Console.WriteLine("Modulus = "+ obj.Modulus(a, b));
        }
    }

}
