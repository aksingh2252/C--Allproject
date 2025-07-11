using System;
namespace Swapusingthirdvariable
{
    class Swaping
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter the First Number = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number = ");
            b = Convert.ToInt32(Console.ReadLine());


            //Using third Variable.
            //c = a;
            //a = b;
            //b = c;


            //Without using Third Variable.
            a = a + b;
            b = a - b;
            a = a - b;






            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);


        }
    }
}