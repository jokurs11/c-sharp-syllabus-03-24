using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] myArray = new int[20];

            Console.WriteLine("Enter the number which you want to find");
            var position = int.Parse(Console.ReadLine());

            for (int i = 0; i < 20; i++)
            {
                int RandomNum = r.Next(20);
                myArray[i] = RandomNum;
            }
            int number = myArray[position];

            Console.WriteLine($"The number at {position} position is {number}");
        }
    }
}