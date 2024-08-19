using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();

            int parsedInput = int.Parse(input);

            if (parsedInput > 0) 
            {
                Console.WriteLine("Number is positive");
            } 
            else if (parsedInput < 0) 
            {
                Console.WriteLine("Number is negative");
            } 
            else 
            {
                Console.WriteLine("Number is zero");
            }

        }
    }
}
