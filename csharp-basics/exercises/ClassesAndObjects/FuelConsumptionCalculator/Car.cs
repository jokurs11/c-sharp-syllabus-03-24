using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    internal class Car
    {
        private double _startKilometers;
        private double _endKilometers; 
        private double _liters;

        public Car(double startOdo, double endingOdo, double liters)
        {
            _startKilometers= startOdo;
            _endKilometers = endingOdo;
            _liters = liters;
        }

        public Car(double onlyOdo)
        {
            _startKilometers = onlyOdo;
        }

        public void StartKilometers(double startingKilometers)
        {
            _startKilometers = startingKilometers;
        }

        public void EndKilometers(double endKilometers)
        {
            _endKilometers = endKilometers;
        }

        public void Liters(double liters)
        {
            _liters = liters;
        }

        public double CalculateConsumption()
        {
            double distanceTraveled = _endKilometers - _startKilometers;
            double fuelConsumption = (_liters / distanceTraveled) * 100;

            return fuelConsumption;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers = mileage;
            _liters = liters;
        }

        public bool IsGasHog()
        {
            double consumedFuel = CalculateConsumption();

            if (consumedFuel >= 15)
            {
                return true;
            }

            return false;
        }

        public bool IsEconomyCar()
        {
            double consumedFuel = CalculateConsumption();

            if (consumedFuel <= 5)
            {
                return true;
            }

            return false;
        }
    }
}
