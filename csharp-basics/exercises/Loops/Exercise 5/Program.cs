using System;
using System.Linq;

namespace Exercise5 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first word:");
            var inputOne = Console.ReadLine();
            Console.WriteLine("Enter the second word:");
            var inputTwo = Console.ReadLine();

            var lineLength = 30;
            var dotsLength = lineLength - inputOne.Length - inputTwo.Length;
            string dots = "";

            for (int i = 0; i <= dotsLength; i++)
            {
                dots = string.Concat(Enumerable.Repeat(".", i));
            }

            Console.WriteLine(inputOne + dots + inputTwo);
        }
    }
}