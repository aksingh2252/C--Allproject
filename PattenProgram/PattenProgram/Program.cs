using System;
namespace PattenPrograme
{
    class Patten
    {
        /*
            1 1 1 1 1 
            2 2 2 2 2
            3 3 3 3 3
            4 4 4 4 4
            5 5 5 5 5
         */

        public int Square()
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            return 0;
        }

        class StarPatten
        {
            static void Main()
            {
                Patten obj = new Patten();
                obj.Square();
            }
        }
    }
}