using System;

namespace Exercise2
{
    class Program
    {
        // TODO: Write a C# program to sum values of an array.
        // Array values are starting from min (including) till max (including) number. 
        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int[] myArray = new int[maxNumber - minNumber + 1];
            int currentNumber = minNumber;

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = currentNumber++;
            }

            Console.WriteLine(" ");
            Console.WriteLine(String.Join(", ", myArray));

            var sum = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];
            }

            Console.WriteLine(" ");
            Console.WriteLine("The sum is " + sum);
        }
    }
}