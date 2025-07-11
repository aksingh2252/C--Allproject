using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculaterdl
{
    public class Calculater
    {
        public int Add(int a , int b)
        {
            

            return a+b;
        }

        public int Sub(int a, int b)
        {
            if (a > b)
            {
                return a - b;              
            }
            else
            {
                return b - a;
            }
        }


        public int Multi(int a , int b)
        {
            return a * b;
        }

        public int div(int a , int b)
        {
            return a / b;
        }

    }
}
