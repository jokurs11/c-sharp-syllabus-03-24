using System;

namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your letters:");
            var input = Console.ReadLine();
            var result = ConvertTextToNumbers(input);
            Console.WriteLine(result);

        }
        private static string ConvertTextToNumbers(string text)
        {
            var result = "";
            foreach (var symbol in text.ToLower())
            {
                if (symbol == 'a' || symbol == 'b' || symbol == 'c')
                {
                    result += 2;
                }
                else if (symbol == 'd' || symbol == 'e' || symbol == 'f')
                {
                    result += 3;
                }
                else if (symbol == 'g' || symbol == 'h' || symbol == 'i')
                {
                    result += 4;
                }
                else if (symbol == 'j' || symbol == 'k' || symbol == 'l')
                {
                    result += 5;
                }
                else if (symbol == 'm'  || symbol == 'n' || symbol == 'o')
                {
                    result += 6;
                }
                else if (symbol == 'p' || symbol == 'q' || symbol == 'r' || symbol == 's')
                {
                    result += 7;
                }
                else if (symbol == 't' || symbol == 'u' || symbol == 'v')
                {
                    result += 8;
                }
                else if (symbol == 'w' || symbol == 'x' || symbol == 'y' || symbol == 'z')
                {
                    result += 9;
                }
            }
            return result;
        }
    }
}