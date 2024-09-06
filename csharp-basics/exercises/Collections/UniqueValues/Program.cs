using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var duplicates = values.GroupBy(w => w)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key);

            Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));
        }
    }
}
