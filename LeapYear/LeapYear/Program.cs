using System;
namespace leapyearprogram
{
    class Leapyear
    {
        static void Main()
        {
            Console.Write("Enter the Year = ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 ==0 && year % 100 != 0)|| (year%400 == 0) )
            {
                Console.WriteLine("Leap Year ");
            }
            else
            {
                Console.WriteLine("Not Leap Year");

            }
        }
    }
}
