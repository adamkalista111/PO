using System;

namespace zadania5
{
    class App5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zad5.1: " + Zad51(50));
            Console.WriteLine("zad5.2: " + Zad52(4,6,8));

            Console.ReadKey();
        }

        private static double Zad51(float c)
        {
            return (c - 32) / 1.8;
        }

        private static bool Zad52(int a, int x, int b)
        {
            return x >= a && x <= b;
        }

    }
}