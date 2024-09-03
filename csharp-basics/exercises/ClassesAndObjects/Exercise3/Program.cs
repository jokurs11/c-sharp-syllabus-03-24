using System;
using System.Security.Cryptography.X509Certificates;

namespace Excercise3
{
    class Program
    {

        private static void Main(string[] args)
        {
            FuelGauge fuelGauge = new FuelGauge();
            Odometer odometer = new Odometer(0, fuelGauge);

            for (int i = 0; i < 70.0; i++)
            {
                fuelGauge.IncreaseFuel();
            }

            while (fuelGauge.GetFuel() > 0)
            {
                odometer.IncreaseMileage();
                Console.WriteLine($"Mileage: {odometer.GetMileage()} km, Fuel: {fuelGauge.GetFuel()} liters");

            }

            Console.WriteLine("The car has run out of fuel.");
        }
    }
}