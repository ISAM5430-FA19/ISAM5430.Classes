using System;

namespace ISAM5430.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1");
            string input = Console.ReadLine(); // returns a string
            int num1 = int.Parse(input);
            Console.WriteLine("Enter number 2");
            input = Console.ReadLine(); // reads a line from the keyboard and assigns to the input variable.
            int num2 = Convert.ToInt32(input);
            Console.WriteLine("Enter the operator: (+, -, /, *)");
            string op = Console.ReadLine();

            if (op == "+")
            {
                // declare an int variable sum.
                // assign the sum of num1 + num2 into the sum variable.
                // print the sum of num1 + num2.,
            }
            // do the same for subtraction, division, and multiplication.
        }
    }
}
