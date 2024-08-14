using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {



            int cars = 100;
            decimal seatsinacar = 4.0m;
            int drivers = 28;
            int passengers = 90;
            int carsnotdriven = cars - drivers;
            int carsdriven = drivers;
            decimal carpoolcapacity = carsdriven * seatsinacar;
            decimal averagepassengerspercar = carpoolcapacity / passengers;



            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsnotdriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolcapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + $"{ averagepassengerspercar:0.00}" + " in each car.");
            Console.ReadKey();
        }
    }
}