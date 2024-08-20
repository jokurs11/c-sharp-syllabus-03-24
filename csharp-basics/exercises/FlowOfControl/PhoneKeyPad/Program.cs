using System;

namespace PhoneKeyPad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your letters:");
            var input = Console.ReadLine().ToLower();
            var result = ConvertTextToNumbers(input);
            var phoneResult = PhoneKeypad(input);

            Console.WriteLine(result);
            Console.WriteLine(phoneResult);
        }

        static string PhoneKeypad(string num)
        {
            var result = "";

            foreach (var character in num)
            {
                switch (character)
                {
                    case 'a': case 'b': case 'c':
                        result += "2";
                        break;
                    case 'd': case 'e': case 'f':
                        result += "3";
                        break;
                    case 'g': case 'h': case 'i':
                        result += "4";
                        break;
                    case 'j': case 'k': case 'l':
                        result += "5";
                        break;
                    case 'm': case 'n': case 'o':
                        result += "6";
                        break;
                    case 'p': case 'q': case 'r': case 's':
                        result += "7";
                        break;
                    case 't': case 'u': case 'v':
                        result += "8";
                        break;
                    case 'w': case 'x': case 'y': case 'z':
                        result += "9";
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            return result;
        }

        private static string ConvertTextToNumbers(string text)
        {
            var result = "";

            foreach (var symbol in text)
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
