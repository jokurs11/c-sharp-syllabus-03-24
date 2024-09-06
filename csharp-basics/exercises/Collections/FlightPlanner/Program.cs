using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string Path = "../../../flights.txt";

        private static void Main(string[] args)
        {
            var flightDictionary = ExtractFlightsToDictionary();
            var flightPath = new List<string>();

            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");

            var choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Pick a starting point:");
                ShowAvailableCities(flightDictionary.Keys.ToList());

                var userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out int startingPointPosition) || startingPointPosition < 1 || startingPointPosition > flightDictionary.Count)
                {
                    Console.WriteLine("Invalid choice. Please select a valid number.");
                    return;
                }

                var firstFlight = GetUserChoiceValue(flightDictionary.Keys.ToList(), startingPointPosition);
                flightPath.Add(firstFlight);

                var destination = string.Empty;
                var firstTime = true;

                while (firstFlight != destination)
                {
                    Console.WriteLine("Pick your destination:");
                    var key = firstTime ? firstFlight : destination;

                    if (!flightDictionary.TryGetValue(key, out var destinations) || destinations.Count == 0)
                    {
                        Console.WriteLine("No available destinations from the current city.");
                        return;
                    }

                    ShowAvailableCities(destinations);

                    userInput = Console.ReadLine();
                    if (!int.TryParse(userInput, out startingPointPosition) || startingPointPosition < 1 || startingPointPosition > destinations.Count)
                    {
                        Console.WriteLine("Invalid choice. Please select a valid number.");
                        return;
                    }

                    destination = GetUserChoiceValue(destinations, startingPointPosition);
                    flightPath.Add(destination);
                    firstTime = false;
                }

                Console.WriteLine("Your flight path is:");
                Console.WriteLine(string.Join(" => ", flightPath));
            }
            else if (choice == "#")
            {
                Console.WriteLine("Exiting program.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select option 1 or #.");
            }
        }

        private static void ShowAvailableCities(List<string> flights)
        {
            var number = 1;
            foreach (var startingPoint in flights)
            {
                Console.WriteLine($"{number}. {startingPoint}");
                number++;
            }
        }

        private static string GetUserChoiceValue(List<string> flights, int startingPointPosition)
        {
            if (startingPointPosition < 1 || startingPointPosition > flights.Count)
            {
                return string.Empty;
            }

            return flights[startingPointPosition - 1];
        }

        private static Dictionary<string, List<string>> ExtractFlightsToDictionary()
        {
            var flightDictionary = new Dictionary<string, List<string>>();

            var lines = File.ReadAllLines(Path);
            foreach (var line in lines)
            {
                var trimmedLine = line.Trim();
                if (string.IsNullOrEmpty(trimmedLine)) continue;

                var parts = trimmedLine.Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length != 2) continue;

                var fromCity = parts[0].Trim();
                var toCity = parts[1].Trim();

                if (!flightDictionary.ContainsKey(fromCity))
                {
                    flightDictionary[fromCity] = new List<string>();
                }
                flightDictionary[fromCity].Add(toCity);
            }

            return flightDictionary;
        }
    }
}