using System;

namespace CheckOddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a random number: ");
            int num = int.Parse(Console.ReadLine());


            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }

            else
            {
                Console.WriteLine("Odd Number");
            }

            Console.WriteLine("Bye!");
        }
    }
}