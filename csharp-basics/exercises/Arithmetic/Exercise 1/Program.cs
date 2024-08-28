using System;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            bool result = (num1 == 15  || num2 == 15 || (num1 + num2 == 15) || (num1 - num2 == 15));

            Console.WriteLine($"The result is: {result}");
        }
    }
}