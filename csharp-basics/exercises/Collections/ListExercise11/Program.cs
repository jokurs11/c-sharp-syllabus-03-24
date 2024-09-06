using System;
using System.Collections.Generic;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList.Add("one");
            myList.Add("two");
            myList.Add("three");
            myList.Add("four");
            myList.Add("five");
            myList.Add("six");
            myList.Add("seven");
            myList.Add("eight");
            myList.Add("nine");
            myList.Add("ten");

            myList.Insert(4, "another five");

            if (myList.Count > 0)
            {
                int lastValue = myList.Count - 1;
                myList[lastValue] = "twelve";
            }

            myList.Sort();

            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i] == "Foobar")
                {
                    Console.WriteLine("List contains foobar");
                }
            }

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }
    }
}
