using static System.Console; // C# 6 syntax that allows you to omit the Console class when calling a method
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print enter the first number
            WriteLine("Enter the first number");
            // input the first number
            int first = int.Parse(ReadLine());
            // print enter the second number
            WriteLine("Enter the first number");
            // input the second number
            int second = Convert.ToInt32(ReadLine());
            // if the first number > second number
            if (first > second)
            {
                //     print the first number
                WriteLine(first);
            }
            // else if the second number > first number
            else if (second > first)
            {
                //     print the second number
                WriteLine(second);
            }
            // else
            else
            {
                //     print both are the same.
                WriteLine("both are the same");
            }
        }
    }
}
