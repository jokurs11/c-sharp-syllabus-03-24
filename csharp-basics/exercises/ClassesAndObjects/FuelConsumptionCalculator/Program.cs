using System;
using System.Threading;

namespace FuelConsumptionCalculator
{
    class CarTest
    {

        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose Audi: 1");
                Console.WriteLine("Choose volvo: 2");
                Console.WriteLine("Choose mazda: 3");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Audi();
                        break;
                    case 2:
                        Volvo();
                        break;
                    case 3:
                        Mazda();
                        break;
                }   
            }
        }

        private static Car _volvo = new Car(0, 0, 0);

        private static void Volvo()
        {
            Console.WriteLine("enter starting kilometers");
            double startKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter ending kilometers");
            double endKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the gas tank capacity in liters");
            double liters = Convert.ToDouble(Console.ReadLine());

            _volvo.StartKilometers(startKm);
            _volvo.EndKilometers(endKm);
            _volvo.Liters(liters);

            Console.WriteLine("The fuel consumption of the car is: " + $"{_volvo.CalculateConsumption():0.00}" + " liters.");

            if (_volvo.IsGasHog())
            {
                Console.WriteLine($"The car is a gas hog.");
            }
            if (_volvo.IsEconomyCar())
            {
                Console.WriteLine($"The car is an economy car.");
            }
        }

        private static Car _audi = new Car(0, 0, 0);

        private static void Audi()
        {
            Console.WriteLine("enter starting kilometers");
            double startKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter ending kilometers");
            double endKm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the gas tank capacity in liters");
            double liters = Convert.ToDouble(Console.ReadLine());

            _audi.StartKilometers(startKm);
            _audi.EndKilometers(endKm);
            _audi.Liters(liters);

            Console.WriteLine("The fuel consumption of the car is: " + $"{_audi.CalculateConsumption():0.00}" + " liters.");

            if (_audi.IsGasHog())
            {
                Console.WriteLine($"The car is a gas hog.");
            }
            if (_audi.IsEconomyCar())
            {
                Console.WriteLine($"The car is an economy car.");
            }
        }

        private static Car _mazda = new Car(13500);

        private static void Mazda()
        {

            _mazda.FillUp(14300, 80);

            Console.WriteLine("First run:");
            Console.WriteLine("The fuel consumption of the car is: " + $"{_mazda.CalculateConsumption():0.00}" + " liters.");


            if (_mazda.IsGasHog())
            {
                Console.WriteLine($"The car is a gas hog.");
            }
            if (_mazda.IsEconomyCar())
            {
                Console.WriteLine($"The car is an economy car.");
            }

            _mazda.FillUp(15900, 80);

            Console.WriteLine("Second run:");
            Console.WriteLine("The fuel consumption of the car is: " + $"{_mazda.CalculateConsumption():0.00}" + " liters.");

            if (_mazda.IsGasHog())
            {
                Console.WriteLine($"The car is a gas hog.");
            }
            if (_mazda.IsEconomyCar())
            {
                Console.WriteLine($"The car is an economy car.");
            }
        }
    }
}
