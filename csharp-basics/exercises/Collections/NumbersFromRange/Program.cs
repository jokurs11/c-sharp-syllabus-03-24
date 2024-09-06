using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var random = new Random();
            var numbers = new List<int>();
            while (numbers.Count() < 10)
            {
                numbers.Add(random.Next(1, 100));
            }

            var filteredNumbers = from number in numbers
                where number > 30 && number < 100
                select number;

            Console.WriteLine("Filtered List (numbers > 30 and < 100): " + string.Join(", ", filteredNumbers));
        }
    }
}
