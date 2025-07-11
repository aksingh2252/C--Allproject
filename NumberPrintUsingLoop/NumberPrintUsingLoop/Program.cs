
using System;
namespace LoopNumberPrint
{
    class LoopForward
    {
        public int UsingwhileLoop()
        {
            int i = 1;
            while (i <= 50)
            {

                Console.Write(i + " ");
                i++;

            }
            return 0;
        }

        public int Usingdowhileloop()
        {
            int i = 1;
            do
            {
                Console.Write(i + " ");
                i++;

            } while (i <= 50);

            return 0;
        }

        public void UsingForLoop()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.Write(i + " ");

            }
        }

    }


    class LoopBackward
    {
        public int UsingwhileLoop()
        {
            int i = 50;
            while (i >= 1)
            {

                Console.Write(i + " ");
                i--;

            }
            return 0;
        }

        public int Usingdowhileloop()
        {
            int i = 50;
            do
            {
                Console.Write(i + " ");
                i--;

            } while (i >= 1);

            return 0;
        }

        public void UsingForLoop()
        {
            for (int i = 50; i >= 1; i--)
            {
                Console.Write(i + " ");

            }
        }
    }



    class Loop
    {
        public static void Main()
        {
            LoopForward forward = new LoopForward();

            Console.WriteLine("By While Loop ");
            forward.UsingwhileLoop();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("By Do While ");
            forward.Usingdowhileloop();

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("By For Loop");
            forward.UsingForLoop();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" BackWard ");


            Console.WriteLine();
            Console.WriteLine();




            LoopBackward Backward = new LoopBackward();
            Console.WriteLine("By While Loop ");
            Backward.UsingwhileLoop();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("By Do While ");
            Backward.Usingdowhileloop();

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("By For Loop");
            Backward.UsingForLoop();




        }
    }
}