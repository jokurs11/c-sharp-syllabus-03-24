using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Hierarchy
{
    public class Cat : Feline
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string breed) :
            base(animalName, animalType, animalWeight, foodEaten)
        {
            _breed = breed;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowwww");
        }

        public override string LivingRegion()
        {
            return "My home";
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

        public override string ToString()
        {
            return base.ToString() + $" It is a {_breed} breed.";
        }
    }
}
