namespace BatchConsole12PM
{
    class ABC
    {
        int i = 1;
        public void MyNonStatic()
        {
            Console.WriteLine(i);
            i++;
        }



        static int n = 1;
        public static void MyStatic()
        {
            Console.WriteLine(n);
            n++;
        }
    }




    class Demo
    {
        static void Main()
        {

            Console.WriteLine("From Non-Static  With Different Object ");
            ABC obj1 = new ABC();
            obj1.MyNonStatic();

            ABC obj2 = new ABC();
            obj2.MyNonStatic();

            ABC obj3 = new ABC();
            obj3.MyNonStatic();

            ABC obj = new ABC();
            Console.WriteLine("From Non-Static  With Same Object ");
            obj.MyNonStatic();
            obj.MyNonStatic();
            obj.MyNonStatic();

            Console.WriteLine("From Static Method ");

            ABC.MyStatic();
            ABC.MyStatic();
            ABC.MyStatic();







        }
    }
}