using System;

namespace ISAM5430.Class03.ProblemD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a count: ");
            int count = int.Parse(Console.ReadLine());
            int countevens = 0;
            int firstHalfSum = 0;
            int secondHalfSum = 0;
            int mid = count / 2;
            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    countevens++;
                }
                if (i < mid)
                {
                    firstHalfSum += num;
                }
                else if (count % 2 == 0 && i >= mid)
                {
                    secondHalfSum += num;
                }
                else if (count % 2 != 0 && i > mid) // 1, 2, 3, 2, 1
                {
                    secondHalfSum += num;
                }
/*              else if (i == mid && count % 2 == 0 || i > mid)
                {
                    secondHalfSum += num;
                }*/
                if (count % 2 == 0)
                {
                    countevens++;
                }
            }
            Console.WriteLine($"Evens: {countevens}");
            Console.WriteLine($"First half == second half? {firstHalfSum == secondHalfSum}");
        }
    }
}
