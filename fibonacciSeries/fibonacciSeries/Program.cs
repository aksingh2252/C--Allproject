using System;
namespace fibonacciSeries
{
    class Fibonacci
    {
        static void Main()
        {
            int n, a = 0, b = 1, c, i;

            Console.Write("Enter the number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());

          

            for (i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}