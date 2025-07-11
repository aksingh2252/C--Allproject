using System;

namespace Tureaction
{
    static class You
    {
        public static bool Reply()
        {
            return false;
        }
    }
        static class Heart
    {
        public static void Happy()
        {
            Console.WriteLine("Heart is happy ❤️");
        }
    }

    static class Actions
    {
        public static void Overthink()
        {
            Console.WriteLine("Overthinking...");
        }

        public static void StareAtScreen()
        {
            Console.WriteLine("Staring at screen...");
        }

        public static void FakeSmile()
        {
            Console.WriteLine("Fake smiling 🙂");
        }

        public static void Smile()
        {
            Console.WriteLine("Smiling 😊");
        }

        public static void ThankUniverse()
        {
            Console.WriteLine("Thanking the universe 🙏");
        }
    }

    class Program
    {
        static void Main(String[] args)
        {
            while (true)
            {
                if (!You.Reply())
                {
                    Actions.Overthink();
                    Actions.StareAtScreen();
                    Actions.FakeSmile();
                }
                else
                {
                    Heart.Happy();
                    Actions.Smile();
                    Actions.ThankUniverse();
                }
            }
        }
    }
}