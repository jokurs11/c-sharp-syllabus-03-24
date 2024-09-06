using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            var uniqueNames = new HashSet<string>();
            bool loop = true;

            do
            {
                Console.WriteLine("Enter your input:");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    loop = false;
                }
                else
                {
                    uniqueNames.Add(input.Trim());
                }
            } while (loop);

            Console.WriteLine("Unique names entered:");

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}