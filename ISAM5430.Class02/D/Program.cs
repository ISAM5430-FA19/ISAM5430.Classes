using System;

namespace D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = int.Parse(Console.ReadLine());

            // i = 0
            int i = 0;
            // min = largest possible
            int min = int.MaxValue;

            // max = smallest possible
            int max = int.MinValue;
            // while i < count
            while (i < count)
            {
                // input num
                int num = Convert.ToInt32(Console.ReadLine());

                // if num < min
                if (num < min)
                {
                    // replace the min with the num
                    min = num;
                }

                // if num > max
                if (num > max)
                {
                    max = num;
                }

                i = i + 1;
            }
            // N, P, C
            Console.WriteLine($"The largest number is {max:N0} and the smallest number is {min:N0}.");
            // print out the maximum value with thousand-commas and no decimal places (0).
        }
    }
}
