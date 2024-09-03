using System;

namespace Excercise8
{
    class Program
    {
        private static void Main(string[] args)
        {
            Points p1 = new Points(5, 2);
            Points p2 = new Points(-3, 6);

            Points.SwapPoints(p1, p2);

            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");

        }
    }
}