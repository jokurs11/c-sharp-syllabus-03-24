using System;

namespace CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var random = rnd.Next(1, 101); // Ensuring the number is between 1 and 100 inclusive

            Console.WriteLine("I'm thinking of a number between 1-100. Try to guess it:");
            var num = int.Parse(Console.ReadLine());

            if (num == random)
            {
                Console.WriteLine("You guessed it! What are the odds?!?");
            }
            else if (num > random)
            {
                Console.WriteLine($"Sorry, you are too high. I was thinking of {random}.");
            }
            else
            {
                Console.WriteLine($"Sorry, you are too low. I was thinking of {random}.");
            }
        }
    }
}