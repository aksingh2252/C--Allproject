using System;
namespace SumandAverage
{
    class Sumandavg
    {
        static void Main()
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                 sum = sum + i;

            }
            Console.WriteLine("Total Sum = "+sum);
            Console.WriteLine("Average = " + sum / 10);


        }
    }
}