using System;

namespace Exercise9
{
    class RollTwoDice
    {
        private const int BaseWidth = 4;
        static void Main(string[] args)
        {
            bool continuePlaying = true;

            do
            {
                Console.WriteLine("Enter your desired sum from 2-12");
                var input = int.Parse(Console.ReadLine());

                Random r = new Random();
                var diceOne = r.Next(1, 7);
                var diceTwo = r.Next(1, 7);
                var sum = diceOne + diceTwo;

                if (input == sum)
                {
                    Console.WriteLine("Congratulations you guessed correctly! You rolled " + diceOne + " and " + diceTwo + " = " + sum);
                    Console.WriteLine("Do you wish to continue playing?");
                    var choice = Console.ReadLine().ToLower();

                    if (choice == "y")
                    {
                        continuePlaying = true;
                    }
                    if (choice == "n")
                    {
                        continuePlaying = false;
                    }
                }

                if (input != sum)
                {
                    Console.WriteLine("You unfortunately didn't guess correctly. You rolled " + diceOne + " and " + diceTwo + " = " + sum);
                    Console.WriteLine("Do you wish to continue playing? y/n");
                    var choice = Console.ReadLine().ToLower();

                    if (choice == "y")
                    {
                        continuePlaying = true;
                    }
                    if (choice == "n")
                    {
                        continuePlaying = false;
                    }
                    if (choice != "n" || choice != "y")
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
                }
            } while (continuePlaying);
        }
    }
}