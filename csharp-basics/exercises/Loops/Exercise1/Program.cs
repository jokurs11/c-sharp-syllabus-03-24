using System;
using System.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNums = [];
            for (int i = 1; i <= 10; i++)
            {
                arrayNums = arrayNums.Append(i).ToArray();
            }

            Console.WriteLine("The first 10 natural numbers are: " + string.Join(", ", arrayNums));
        }
    }
}