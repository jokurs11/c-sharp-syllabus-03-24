using System;

namespace Exercise10
{
    class NumberSquare
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter min number:");
            var minNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter max number:");
            var maxNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < maxNumber - minNumber + 1; i++)
            {
                for (int j = 0; j < maxNumber - minNumber + 1; j++)
                {
                    if ((minNumber + j + i) <= maxNumber)
                    {
                        Console.Write($"{minNumber + j + i} ");
                    }
                    else
                    {
                        Console.Write($"{j - maxNumber + minNumber + i + minNumber - 1} ");
                    }
                }

                Console.WriteLine();
            }

            for (var i = minNumber; i <= maxNumber; i++)
            {
                for (var j = i; j <= maxNumber + i - minNumber; j++)
                {
                    if (j <= maxNumber)
                    {
                        Console.Write($"{j} ");
                    }
                    else
                    {
                        Console.Write($"{j - maxNumber + minNumber - 1} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}