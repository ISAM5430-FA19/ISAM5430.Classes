using System;

namespace ISAM5430.Class03
{
    class Program
    {
        static void Main()
        {
            int prevprev = 0;
            int prev = 1;
            Console.WriteLine(prevprev);
            Console.WriteLine(prev);
            for (int i = 2; i < 25; i++)
            {
                int sum = prev + prevprev;
                Console.WriteLine(sum);
                // next iteration
                prevprev = prev;
                prev = sum;
            }
        }
        static void C1_7(string[] args)
        {
            char c = 'a'; // 97
            while (c <= 'z')
            {
                Console.WriteLine(c);
                c++;
            }   
        }
    }
}
