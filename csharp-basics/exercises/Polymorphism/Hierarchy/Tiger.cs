using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tiger : Feline
    {
        private string _livingRegion;

        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) :
            base(animalName, animalType, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public override void MakeSound()
        {
            Console.WriteLine("ROAAR!!!");
        }

        public override string LivingRegion()
        {
            return _livingRegion;
        }

        public override string Eat(Food food)
        {
            if (food is Meat)
            {
                _foodEaten += food._quantity;
                return $"{_animalName} ate {food._quantity} meat.";
            }
            else
            {
                return $"{_animalName}s do not eat that type of food!";
            }
        }
    }
}
