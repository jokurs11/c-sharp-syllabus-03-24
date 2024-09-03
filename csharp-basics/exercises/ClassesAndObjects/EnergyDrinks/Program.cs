using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int numberedSurveyed = 12467;
        private const double purchasedEnergyDrinks = 0.14;
        private const double preferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
             Console.WriteLine("Total number of people surveyed " + numberedSurveyed);
             Console.WriteLine($"Approximately {CalculateEnergyDrinkers(numberedSurveyed):0} bought at least one energy drink");
             Console.WriteLine($"{CalculatePreferCitrus(numberedSurveyed):0} of those prefer citrus flavored energy drinks.");
        }

        private static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            double energyDrinkers = numberSurveyed * purchasedEnergyDrinks;
            return energyDrinkers;
        }

        private static double CalculatePreferCitrus(int numberSurveyed)
        {
            double preferCitrus = CalculateEnergyDrinkers(numberedSurveyed) * preferCitrusDrinks;
            return preferCitrus;
        }
    }
}
