using System;
using System.Linq;

namespace Exercise7
{
    class Piglet
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to piglet!");

            Random r = new Random();
            var score = 0;
            var loops =0;
            bool continuePlaying = true;

            do 
            {
                var dice = r.Next(1, 7);

                if (dice == 2)
                {
                    loops++;
                    Console.WriteLine("You rolled a 2!");
                    score += dice;
                    Console.WriteLine("Your current score is " + score + ".");
                    Console.WriteLine("You have so far rolled " + loops + " times in a row.");
                    Console.WriteLine("Will you continue playing? y/n.");
                    var continuePlay = Console.ReadLine().ToLower();

                    if (continuePlay == "n")
                    {
                        Console.WriteLine("Your game ended with a score of " + score + ".");
                        Console.ReadKey();
                        break;
                    }
                }
                if (dice == 3)
                {
                    loops++;
                    Console.WriteLine("You rolled a 3!");
                    score += dice;
                    Console.WriteLine("Your current score is " + score + ".");
                    Console.WriteLine("You have so far rolled " + loops + " times in a row.");
                    Console.WriteLine("Will you continue playing? y/n.");
                    var continuePlay = Console.ReadLine().ToLower();

                    if (continuePlay == "n")
                    {
                        Console.WriteLine("Your game ended with a score of " + score + ".");
                        Console.ReadKey();
                        break;
                    }
                }
                if (dice == 4)
                {
                    loops++;
                    Console.WriteLine("You rolled a 4!");
                    score += dice;
                    Console.WriteLine("Your current score is " + score + ".");
                    Console.WriteLine("You have so far rolled " + loops + " times in a row.");
                    Console.WriteLine("Will you continue playing? y/n.");
                    var continuePlay = Console.ReadLine().ToLower();

                    if (continuePlay == "n")
                    {
                        Console.WriteLine("Your game ended with a score of " + score + ".");
                        Console.ReadKey();
                        break;
                    }
                }
                if (dice == 5)
                {
                    loops++;
                    Console.WriteLine("You rolled a 5!");
                    score += dice;
                    Console.WriteLine("Your current score is " + score + ".");
                    Console.WriteLine("You have so far rolled " + loops + " times in a row.");
                    Console.WriteLine("Will you continue playing? y/n.");
                    var continuePlay = Console.ReadLine().ToLower();

                    if (continuePlay == "n")
                    {
                        Console.WriteLine("Your game ended with a score of " + score + ".");
                        Console.ReadKey();
                        break;
                    }
                }
                if (dice == 6)
                {
                    loops++;
                    Console.WriteLine("You rolled a 6!");
                    score += dice;
                    Console.WriteLine("Your current score is " + score + ".");
                    Console.WriteLine("You have so far rolled " + loops + " times in a row.");
                    Console.WriteLine("Will you continue playing? y/n.");
                    var continuePlay = Console.ReadLine().ToLower();

                    if (continuePlay == "n")
                    {
                        Console.WriteLine("Your game ended with a score of " + score + ".");
                        Console.ReadKey();
                        break;
                    }
                }
                if (dice == 1)
                {
                    score = 0;
                    Console.WriteLine("You rolled a 1! Game over.");
                    Console.WriteLine("Your game ended with a score of " + score + ".");
                    Console.WriteLine("In total you rolled " + loops + " times before the game ended.");
                    Console.WriteLine("Will you play again? y/n");
                    var inputAgain = Console.ReadLine().ToLower();

                    if (inputAgain == "y")
                    {
                        loops = 0;
                        continuePlaying = true;
                    }
                    if (inputAgain == "n")
                    {
                        Console.ReadKey();
                        break;
                    }
                }
            } while (continuePlaying);
        }
    }
}