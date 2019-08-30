using System; // java's import
/*
 multiline comment
     */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISAM5430.Class01A
{
    class Program
    {
        // entry-point in the console app
        static void Main(string[] args)
        {
            // declaring a variable as a string
            string person = "Michael"; // initializing a variable
            // string interpolation

            Console.WriteLine($"Welcome to C# Programming, {person}.");

            Console.WriteLine("Welcome to C# Programming, {0}.", person);

            Console.WriteLine(string.Format("Welcome to C# Programming, {0}", person));

            Console.WriteLine("Welcome to C# Progrmming, " + person + ".");
        }
    }
}
