using System;

namespace ISAM5430.Class05
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor
            // the default constructor that is parameterless
            Account account = new Account("mike", false);
            // a constructor forces you to initialize the required states
            account.SetName("Mike");
            Console.WriteLine("The name is " + account.GetName());
            account.Name = "";
            // account.set_Name("Wu");
            // account.IsActive = true;
            // account.Is_Active = true;

            Console.WriteLine("Is the account active? " + account.IsActive);
            Console.WriteLine("The name 2 is " + account.Name);
            // Fully qualified type name, which includes a namespace "dot" type name
            Console.WriteLine(account.ToString());
            Console.WriteLine(account);
        }
    }
}
