using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    class Program
    {
        private const string Path = "../../../lear.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var lineCount = 0;
            using (var reader = File.OpenText(Path))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Console.WriteLine("Lines: " + lineCount);

            var readFile = File.ReadAllText(Path);
            var str = readFile.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Words: " + str.Length);

            string chars = File.ReadAllText(Path);
            Console.Write("Chars: " + chars.Length);
            Console.WriteLine();
        }
    }
}