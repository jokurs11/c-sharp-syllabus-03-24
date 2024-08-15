using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {

            string Name = "Zed A. Shaw";
            int Age = 35;
            int Height = 74;  // inches
            int Weight = 180; // lbs
            string Eyes = "Blue";
            string Teeth = "White";
            string Hair = "Brown";
            decimal WeightKg = Weight * 0.453592m;
            decimal HeightCm = Height * 2.54m;

            Console.WriteLine("Let's talk about " + Name + ".");
            Console.WriteLine("He's " + Height + " inches tall.");
            Console.WriteLine("He's " + Weight + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + Eyes + " eyes and " + Hair + " hair.");
            Console.WriteLine("His teeth are usually " + Teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + Age + ", " + HeightCm  + ", and " + $"{WeightKg:0.00}"
                               + " I get " + $"{(Age + HeightCm + WeightKg):0.00}" + ".");

            Console.ReadKey();
        }
    }
}