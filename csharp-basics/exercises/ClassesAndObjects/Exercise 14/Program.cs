using System;

namespace Excercise14
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dates firstDate = new Dates(1970, 9, 21);
            Dates secondDate = new Dates(1945, 9, 2);
            Dates thirdDate = new Dates(2001, 9, 11);

            Console.WriteLine(firstDate.WeekdayInDutch());
            Console.WriteLine(secondDate.WeekdayInDutch());
            Console.WriteLine(thirdDate.WeekdayInDutch());
        }
    }
}