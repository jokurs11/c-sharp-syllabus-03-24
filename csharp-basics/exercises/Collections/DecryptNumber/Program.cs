using System;
using System.Collections.Generic;
using System.Linq;

namespace DecryptNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cryptedNumbers = new List<string>
            {
                "())(",
                "*$(#&",
                "!!!!!!!!!!",
                "$*^&@!",
                "!)(^&(#@",
                "!)(#&%(*@#%"
            };

            var symbolsMap = new Dictionary<char, char>
            {
                { ')', '0' },
                { '!', '1' },
                { '@', '2' },
                { '#', '3' },
                { '$', '4' },
                { '%', '5' },
                { '^', '6' },
                { '&', '7' },
                { '*', '8' },
                { '(', '9' }
            };

            foreach (var cryption in cryptedNumbers)
            {
                Console.WriteLine(DecryptWithLinq(cryption, symbolsMap));
            }
        }

        static string DecryptWithLinq(string crypted, Dictionary<char, char> symbolToNumberMap)
        {
            return new string(crypted.Select(c =>
            {
                if (symbolToNumberMap.ContainsKey(c))
                {
                    return symbolToNumberMap[c];
                }
                else
                {
                    return c;
                }
            }).ToArray());
        }
    }
}