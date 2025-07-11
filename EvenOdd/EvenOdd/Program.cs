using System;
namespace EvenOddPrograme
{
    class Even
    {
        public void Usingwhileloop()
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }

        }

        public void Usingdowhileloop()
        {
            int i = 1;
            do
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");

                }
                i++;


            } while (i <= 100);
        }

        public void UsingforLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }

    class Odd
    {
        public void Usingwhileloop()
        {
            int i = 1;
            while (i <= 100)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
                i++;
            }

        }

        public void Usingdowhileloop()
        {
            int i = 1;
            do
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");

                }
                i++;


            } while (i <= 100);
        }

        public void UsingforLoop()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }

    }
    class EvenOdd
    {
        static void Main()
        {
            Even EvenObj = new Even();

            Console.WriteLine("By While ");
            EvenObj.Usingwhileloop();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("By Do While ");
            EvenObj.Usingdowhileloop();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("By For While ");
            EvenObj.UsingforLoop();



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Odd Number ");


            Odd oddobj = new Odd();
           

            Console.WriteLine("By While ");
            oddobj.Usingwhileloop();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("By Do While ");
            oddobj.Usingdowhileloop();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("By For While ");
            oddobj.UsingforLoop();




        }
    }
}