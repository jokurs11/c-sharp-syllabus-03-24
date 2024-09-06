using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var daysOfWeek = new List<string>
        {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

        var query = from day in daysOfWeek
            select day;

        Console.WriteLine("Days of the week:");
        foreach (var day in query)
        {
            Console.WriteLine(day);
        }
    }
}