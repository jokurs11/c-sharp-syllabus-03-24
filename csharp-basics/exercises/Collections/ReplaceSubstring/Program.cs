using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            var updatedWords = from word in words
                select word.Replace("ea", "*");

            Console.WriteLine(string.Join(", ", updatedWords));
        }
    }
}

