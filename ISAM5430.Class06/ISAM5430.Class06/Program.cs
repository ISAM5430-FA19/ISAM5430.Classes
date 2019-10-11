using System;
using static System.Math;

namespace ISAM5430.Class06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PI);
            Console.WriteLine(E);
            Console.WriteLine(Sqrt(9));
            Console.WriteLine(Math.Pow(10, 4));
            Console.WriteLine(Math.Exp(4));
            Console.WriteLine(Math.Exp(Math.Log(10) * 4));
            Console.WriteLine(Math.Max(Math.Max(4, 5), 10));
            Console.WriteLine(Max(4, 2, 5, 1));
        }

        public static int Max(int a, int b)
        {
            return Math.Max(a, b);
        }

        public static int Max(int a, int b, int c)
        {
            return Max(Max(a, b), c);
        }

        public static int Max(int a, int b, int c, int d)
        {
            return Max(Max(b, c, a), d);
        }

    }
}
