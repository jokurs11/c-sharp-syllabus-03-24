using System;
using System.Collections.Generic;

namespace Exercise10
{

    class Program
    {

        private static void Main(string[] args)
        {
            HashSet<string> myList = new HashSet<string>();

            myList.Add("one");
            myList.Add("two");
            myList.Add("three");
            myList.Add("four");
            myList.Add("five");


            foreach (var word in myList)
            {
                Console.WriteLine(word);
            }

            myList.Clear();

            myList.Add("one");
            myList.Add("one");

            foreach (var word in myList)
            {
                Console.WriteLine($"Checking if duplicated values are added: {word}");
            }
        }
    }
}
