using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Feline : Mammal
    {
        public Feline(string animalName, string animalType, double animalWeight, int foodEaten) :
            base(animalName, animalType, animalWeight, foodEaten)
        {
        }

        public override void MakeSound()
        {
        }

        public override string LivingRegion()
        {
            return null;
        }

        public override string Eat(Food food)
        {
            return null;
        }

        public virtual string ToString()
        {
            return $"{_animalName} is a {_animalType}, weighs {_animalWeight}kg, and he eats {_foodEaten} times.";
        }
    }
}
