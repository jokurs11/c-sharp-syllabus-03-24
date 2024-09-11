using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var _cat = new Cat("Cat", "Feline", 4.6, 0, "Siamese");
            var _zebra = new Zebra("Zebra", "Mammal", 400, 0);
            var _mouse = new Mouse("Mouse", "Mammal", 0.03, 0);
            var _tiger = new Tiger("Tiger", "Feline", 250, 0, "Africa");

            Food _vegetable = new Vegetable(3);
            Food _meat = new Meat(4);

            _cat.MakeSound();
            Console.WriteLine(_cat.Eat(_meat));
            Console.WriteLine(_cat.Eat(_vegetable));
            Console.WriteLine(_cat.ToString());
            Console.WriteLine();

            _zebra.MakeSound();
            Console.WriteLine(_zebra.Eat(_meat));
            Console.WriteLine(_zebra.Eat(_vegetable));
            Console.WriteLine(_zebra.ToString());
            Console.WriteLine();

            _mouse.MakeSound();
            Console.WriteLine(_mouse.Eat(_meat));
            Console.WriteLine(_mouse.Eat(_vegetable));
            Console.WriteLine(_mouse.ToString());
            Console.WriteLine();

            _tiger.MakeSound();
            Console.WriteLine(_tiger.Eat(_meat));
            Console.WriteLine(_tiger.Eat(_vegetable));
            Console.WriteLine(_tiger.ToString());
            Console.WriteLine();
        }
    }
}