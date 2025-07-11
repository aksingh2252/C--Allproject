using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BatchConsole
{
    public abstract class A
    {
        public abstract int Sum(int a, int b);
    }

    class Demo : A
    {

        public override int Sum(int a, int b)
        {
            return a + b;
        }
        public static void Main()
        {
        

        Demo obj = new Demo();
            int ak = obj.Sum(4, 2);
            Console.WriteLine(ak);
        }
    }
}