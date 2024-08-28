using System;

namespace PrintDayInWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day:");
            var dayNumber = Convert.ToInt32(Console.ReadLine());

            if (dayNumber == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (dayNumber == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (dayNumber == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (dayNumber == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (dayNumber == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (dayNumber == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (dayNumber == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }
    }
}