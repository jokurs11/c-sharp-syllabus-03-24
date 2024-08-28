using System;

namespace Hangman
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] words = { "tree", "lighter", "horse", "computer", "star", "cloud" };

            Random wordSelector = new Random();
            string selectedWord = words[wordSelector.Next(words.Length)];

            char[] maskedWord = new char[selectedWord.Length];
            for (int i = 0; i < selectedWord.Length; i++)
            {
                maskedWord[i] = '_';
            }
            int count = 0;
            List<string> missedLetters = new List<string>();

            while (new string(maskedWord).Contains('_') && count < 10)
            {
                int remainingAttempts = 10 - count;

                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine("You have " + remainingAttempts + " attempts remaining");
                Console.WriteLine("Misses: " + string.Join(", ", missedLetters));
                Console.WriteLine("Current word: " + new string(maskedWord));
                Console.WriteLine("Enter your guess:");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-");
                string input = Console.ReadLine();

                char guessedChar = input[0];
                bool foundMatch = false;
                for (int j = 0; j < selectedWord.Length; j++)
                {
                    if (selectedWord[j] == guessedChar)
                    {
                        maskedWord[j] = guessedChar;
                        foundMatch = true;
                    }
                }
                if (!foundMatch)
                {
                    missedLetters.Add(input);
                    Console.WriteLine("Incorrect guess!");
                    count++;
                }
                else
                {
                    Console.WriteLine("Your guess was correct!");
                }

                Console.WriteLine("Masked word: " + new string(maskedWord));
            }
            if (new string(maskedWord).Contains('_'))
            {
                Console.WriteLine("You have run out of attempts. The word was: " + selectedWord);
            }
            else
            {
                Console.WriteLine("Congratulations! You have guessed the word: " + selectedWord);
            }
        }
    }
}