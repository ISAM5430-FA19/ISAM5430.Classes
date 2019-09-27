using System;
using static System.Console;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char a = 'A'; a <= 'H'; a++)
            {
                // 4c
                bool vowelA = a == 'A' || a == 'E'; 
                for(char b = 'A'; b<= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels2 >= 1)
                    {
                        Write($"{a}{b} ");
                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';

                        //if (a == 'A' || a == 'E' || b == 'A' || b == 'E' || c == 'A' || c == 'E')
                        int vowels = vowels2 + (vowelC ? 1 : 0);
                        // int consonants = (!vowelA ? 1 : 0) + (!vowelB ? 1 : 0) + (!vowelC ? 1 : 0);

                        // var x = booleanStatement == true ? trueStatement : falseStatement. <-- C-like language
                        // x = trueStatement if booleanStatement == True else falseStatement. <-- PYTHON

                        if (vowels == 1 || vowels == 2 || vowels == 3)
                            Write($"{a}{b}{c} ");
                    }
                }
            }
        }
    }
}
