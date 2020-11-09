using System;

namespace testing
{
    class Program
    {
        private static void hum()
        {
            Console.WriteLine("Yass");
        }
        static void Main(string[] args)
        {
            Vliegtuig f1 = new Vliegtuig();
            Raket spaceX1 = new Raket();
            f1.Vlieg();
            spaceX1.Vlieg();


        }
    }
}
