using System;

namespace Excercise13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Smoothie _smoothie1 = new Smoothie(new string[] { "Banana" });
            Console.WriteLine(string.Join(", ", _smoothie1.Ingredients));
            Console.WriteLine(_smoothie1.GetCost());
            Console.WriteLine(_smoothie1.GetPrice());
            Console.WriteLine(_smoothie1.GetName());
            Console.WriteLine();

            Smoothie _smoothie2 = new Smoothie(new string[] { "Raspberries", "Strawberries", "Blueberries" });
            Console.WriteLine(string.Join(", ", _smoothie2.Ingredients));
            Console.WriteLine(_smoothie2.GetCost());
            Console.WriteLine(_smoothie2.GetPrice());
            Console.WriteLine(_smoothie2.GetName());
        }
    }
}