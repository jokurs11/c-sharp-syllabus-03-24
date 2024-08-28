using System;

namespace Excercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            var number = int.Parse(Console.ReadLine());

            var inputNumber = number;

            var sumOfDigits = 0;

            while (inputNumber > 0)
            {
                sumOfDigits += inputNumber % 10;
                inputNumber /= 10;
            }

            if (number % sumOfDigits == 0)
            {
                var dividedNumber = number / sumOfDigits;
                bool isPrime = true;

                if (dividedNumber < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (var i = 2; i <= Math.Sqrt(dividedNumber); i++)
                    {
                        if (dividedNumber % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("M");
                }
                else
                {
                    Console.WriteLine("H");
                }
            }
            else
            {
                Console.WriteLine("Neither");
            }
        }
    }
}