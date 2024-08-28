using System;

namespace GravityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double gravity = -9.81;  // Earth's gravity in m/s^2
            double fallingTime = 10.0;


            double finalPosition = 0.5 * gravity * fallingTime * fallingTime;



            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + $"{finalPosition:0.0}" + " m.");
            Console.ReadKey();
        }
    }
}