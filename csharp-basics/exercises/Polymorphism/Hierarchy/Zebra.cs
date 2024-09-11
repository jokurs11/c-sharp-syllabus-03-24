using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten) :
            base(animalName, animalType, animalWeight, foodEaten)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hoink");
        }

        public override string LivingRegion()
        {
            return "Africa";
        }

        public override string Eat(Food food)
        {
            if (food is Vegetable)
            {
                _foodEaten += food._quantity;
                return $"{_animalName} ate {food._quantity} vegetables.";
            }
            else
            {
                return $"{_animalName}s do not eat that type of food!";
            }
        }
    }
}
