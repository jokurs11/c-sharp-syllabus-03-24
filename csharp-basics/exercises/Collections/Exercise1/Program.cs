using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Car
    {
        public string _maker { get; set; }
        public string _origin { get; set; }

        public Car(string maker, string origin)
        {
            _maker = maker;
            _origin = origin;
        }
    }

    class Program
    {
        private static string _audi = "Germany";
        private static string _bmw = "Germany";
        private static string _honda = "Japan";
        private static string _mercedes = "Germany";
        private static string _volkswagen = "Germany";
        private static string _tesla = "USA";

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Tesla" };

            List<Car> myList1 = new List<Car>
            {
                new Car (array[0], _audi ),
                new Car (array[1], _bmw ),
                new Car (array[2], _honda),
                new Car (array[3], _mercedes),
                new Car (array[4], _volkswagen),
                new Car (array[5], _tesla),
            };

            foreach (Car car in myList1)
            {
                Console.WriteLine($"{car._maker} is made in {car._origin}");
            }

            Console.WriteLine();

            HashSet<Car> myList2 = new HashSet<Car>
            {
                new Car(array[0], _audi),
                new Car(array[1], _bmw),
                new Car(array[2], _honda),
                new Car(array[3], _mercedes),
                new Car(array[4], _volkswagen),
                new Car(array[5], _tesla),
            };

            foreach (Car car in myList2)
            {
                Console.WriteLine($"{car._maker} is made in {car._origin}");
            }

            Console.WriteLine();

            Dictionary<string, string> carList3 = new Dictionary<string, string>
            {
                { array[0], _audi },
                { array[1], _bmw },
                { array[2], _honda },
                { array[3], _mercedes },
                { array[4], _volkswagen },
                { array[5], _tesla }
            };

            foreach (KeyValuePair<string, string> entry in carList3)
            {
                Console.WriteLine($"{entry.Key} is made in {entry.Value}");
            }
        }
    }
}
