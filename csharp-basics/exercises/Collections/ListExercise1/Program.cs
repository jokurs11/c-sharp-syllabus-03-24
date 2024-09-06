using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> myList = new List<string>();

            myList.Add("Blue");
            myList.Add("Red");
            myList.Add("Yellow");
            myList.Add("Cyan");
            myList.Add("Purple");

            Console.WriteLine(String.Join(", ", myList));
        }
    }
}
