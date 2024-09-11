using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Hierarchy
{
    public abstract class Animal
    {
        protected string _animalName;
        protected string _animalType;
        protected double _animalWeight;
        protected int _foodEaten;

        public Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public abstract void MakeSound();

        public abstract string Eat(Food food);
    }
}
