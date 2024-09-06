using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../../midtermscores.txt";

        private static void Main(string[] args)
        {
            var scores = ReadScoresFromFile(Path);

            var histogram = CreateHistogram(scores);

            DisplayHistogram(histogram);
        }

        static List<int> ReadScoresFromFile(string filePath)
        {
            var scoreList = new List<int>();
            var readText = File.ReadAllText(filePath);

            var scores = readText.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            return scores;
        }

        static Dictionary<string, int> CreateHistogram(List<int> scores)
        {
            var histogram = new Dictionary<string, int>()
            {
                { "00-09", 0 },
                { "10-19", 0 },
                { "20-29", 0 },
                { "30-39", 0 },
                { "40-49", 0 },
                { "50-59", 0 },
                { "60-69", 0 },
                { "70-79", 0 },
                { "80-89", 0 },
                { "90-99", 0 },
                { "  100", 0 }
            };

            foreach (var score in scores)
            {
                if (score >= 0 && score <= 9)
                    histogram["00-09"]++;
                else if (score >= 10 && score <= 19)
                    histogram["10-19"]++;
                else if (score >= 20 && score <= 29)
                    histogram["20-29"]++;
                else if (score >= 30 && score <= 39)
                    histogram["30-39"]++;
                else if (score >= 40 && score <= 49)
                    histogram["40-49"]++;
                else if (score >= 50 && score <= 59)
                    histogram["50-59"]++;
                else if (score >= 60 && score <= 69)
                    histogram["60-69"]++;
                else if (score >= 70 && score <= 79)
                    histogram["70-79"]++;
                else if (score >= 80 && score <= 89)
                    histogram["80-89"]++;
                else if (score >= 90 && score <= 99)
                    histogram["90-99"]++;
                else if (score == 100)
                    histogram["  100"]++;
            }

            return histogram;
        }

        static void DisplayHistogram(Dictionary<string, int> histogram)
        {
            foreach (var entry in histogram)
            {
                Console.WriteLine($"{entry.Key}: {new string('*', entry.Value)}");
            }
        }
    }
}