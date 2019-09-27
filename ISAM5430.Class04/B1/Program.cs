using System;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            // print out five numbers between 1 and 5:
            for(int i=1; i <= 5; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    if (i != j)
                    {


                        for (int z = 1; z <= 5; z++)
                        {
                            if (j != z && z != i) {
                                sum += i * j * z;
                                Console.WriteLine("Sum: " + sum);
                            }
                        }
                    }
                    
                }


                
            }

            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int z = j + 1; z <= 5; z++)
                    {
                        Console.WriteLine(i + ", " + j + ", " + z);
                    }

                }
            }


            // 1, 2, 3; 1, 2, 4; 1, 2, 5; 1, 2, 6; 2, 3, 4; 2, 3, 5; 2, 3, 6; 3, 4, 5; 3, 4, 6; 4, 5, 6.
            // Brute-Forcing: trying out all possibliities/combinations.


        }
    }
}
