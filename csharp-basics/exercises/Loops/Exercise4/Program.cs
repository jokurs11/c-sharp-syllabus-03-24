using System;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            char[] joinedVowelsFor = [];
            char[] joinedVowelsForeach = [];

            for (int i = 0; i < vowels.Length; i++)
            {
                joinedVowelsFor = joinedVowelsFor.Append(vowels[i]).ToArray();
            }

            Console.WriteLine("All the joined vowels in a 'for' loop: " + string.Join(", ", joinedVowelsFor));

            foreach (char letter in vowels)
            {
                joinedVowelsForeach = joinedVowelsForeach.Append(letter).ToArray();
            }

            Console.WriteLine("All the joined vowels in a 'foreach' loop: " + string.Join(", ", joinedVowelsForeach));
        }
    }
}