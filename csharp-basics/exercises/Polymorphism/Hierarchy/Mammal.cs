using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        public Mammal(string animalName, string animalType, double animalWeight, int foodEaten) : 
            base(animalName, animalType, animalWeight, foodEaten)
        {
        }
        public override void MakeSound()
        {
        }

        public abstract string LivingRegion();

        public override string Eat(Food food)
        {
            return null;
        }

        public string ToString()
        {
            return $"{_animalName} is a {_animalType}, weighs {_animalWeight}kg, and he eats {_foodEaten} times.";
        }
    }
}
