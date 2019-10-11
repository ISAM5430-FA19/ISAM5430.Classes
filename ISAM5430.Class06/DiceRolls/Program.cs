using System;

namespace DiceRolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRolls;
            Console.WriteLine("Enter number of rolls:");
            if (int.TryParse(Console.ReadLine(), out numRolls))
            {
                int dice1, dice2, dice3, dice4, dice5, dice6;
                DiceRoll(numRolls, out dice1, out dice2, out dice3, out dice4,
                    out dice5, out dice6);
                Console.WriteLine($"Dice 1: {dice1:N0}");
                Console.WriteLine($"Dice 2: {dice2:N0}");
                Console.WriteLine($"Dice 3: {dice3:N0}");
                Console.WriteLine($"Dice 4: {dice4:N0}");
                Console.WriteLine($"Dice 5: {dice5:N0}");
                Console.WriteLine($"Dice 6: {dice6:N0}");
            }
        }

        public override string ToString()
        {
            return "string representation of the object";
        }
        static void DiceRoll(int numberOfRolls, out int dice1, out int dice2,
            out int dice3, out int dice4, out int dice5, out int dice6)
        {
            Random random = new Random();
            dice1 = 0;
            dice2 = 0;
            dice3 = 0;
            dice4 = 0;
            dice5 = 0;
            dice6 = 0;
            for (int i = 1; i <= numberOfRolls; i++)
            {
                int dice = random.Next(1, 7);
                switch (dice)
                {
                    case 1:
                        dice1++;
                        break;
                    case 2:
                        dice2++;
                        break;
                    case 3:
                        dice3++;
                        break;
                    case 4:
                        dice4++;
                        break;
                    case 5:
                        dice5++;
                        break;
                    case 6:
                        dice6++;
                        break;
                }
            }

        }
    }
}
