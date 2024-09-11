using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program

    {
        /**
    * Take a look at the cars in this solution.
    * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
    * Which methods will be extracted with an empty body, and which can be default?
    * 2. Create two more cars of your own choice.
    * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
    * 4. Create one instance of an each car and add them to list.
    * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
    * 6. Print out the car name and speed of the fastest car
    */

        private static void Main(string[] args)
        {
            Audi _audi = new Audi();
            Bmw _bmw = new Bmw();
            Lexus _lexus = new Lexus();
            Mercedes _mercedes = new Mercedes();
            Tesla _tesla = new Tesla();
            Volkswagen _volkswagen = new Volkswagen();

            var _cars = new List<Car>()
            {
                _audi, _bmw, _lexus, _mercedes, _tesla, _volkswagen
            };

            List<Iboost> _boostableCars = new List<Iboost>()
            {
                _lexus, _mercedes
            };

            foreach (Car car in _cars)
            {
                car.StartEngine();
            }

            for (int i = 1; i < 10; i++)
            {
                foreach (Car car in _cars)
                {
                    car.SpeedUp();

                    if (int.Parse(car.ShowCurrentSpeed()) > 10)
                    {
                        car.SlowDown();
                    }
                }

                foreach (Iboost car in _boostableCars)
                {
                    if (i == 3)
                    {
                        car.UseNitrousOxideEngine();
                    }
                }
            }

            var maxSpeed = _cars.Max(car => Convert.ToInt32(car.ShowCurrentSpeed()));
            var fastestCar = _cars.First(car => int.Parse(car.ShowCurrentSpeed()) == maxSpeed);

            Console.WriteLine($"{fastestCar.GetType().Name}: {maxSpeed}");
        }
    }
}
    

