using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you choose rock, paper or scissors");
            var input = Console.ReadLine();

            var userChoice = input.ToLower();

            Random rando = new Random();
            var computerChoice = rando.Next(3);

            if (computerChoice == 0)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("It is a tie ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("It is a tie ");
                }
                else
                {
                    Console.WriteLine("Invalid input! It has to be either rock, paper, or scissors!");
                }
            }
            else if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Sorry you lose, paper beat rock");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose, scissors beat paper ");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Sorry you lose, rock beats scissors");
                }
                else
                {
                    Console.WriteLine("Invalid input! It has to be either rock, paper, or scissors!");
                }
            }
            else if (computerChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win, rock beats scissors");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win, paper beats rock");
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win, scissors beat paper");
                }
                else
                {
                    Console.WriteLine("Invalid input! It has to be either rock, paper, or scissors!");
                }
            }
        }
    }
}
