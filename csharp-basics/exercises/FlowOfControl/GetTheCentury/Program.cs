using System;

namespace GetTheCentury
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year: ");
            var input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1001 && input <= 1100)
            {
                Console.WriteLine("11th century");
            }
            else if (input >= 1101 && input <= 1200)
            {
                Console.WriteLine("12th century");
            }
            else if (input >= 1201 && input <= 1300)
            {
                Console.WriteLine("13th century");
            }
            else if (input >= 1301 && input <= 1400)
            {
                Console.WriteLine("14th century");
            }
            else if (input >= 1401 && input <= 1500)
            {
                Console.WriteLine("15th century");
            }
            else if (input >= 1501 && input <= 1600)
            {
                Console.WriteLine("16th century");
            }
            else if (input >= 1601 && input <= 1700)
            {
                Console.WriteLine("17th century");
            }
            else if (input >= 1701 && input <= 1800)
            {
                Console.WriteLine("18th century");
            }
            else if (input >= 1801 && input <= 1900)
            {
                Console.WriteLine("19th century");
            }
            else if (input >= 1901 && input <= 2000)
            {
                Console.WriteLine("20th century");
            }
            else if (input >= 2001 && input <= 2010)
            {
                Console.WriteLine("21st century");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
