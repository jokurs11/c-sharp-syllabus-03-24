using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Exercise5
{
    class Program
    {

        public class HappyNumber
        {
            public static int isHappyNumber(int num)
            {
                int rem = 0, sum = 0;

                while (num > 0)
                {
                    rem = num % 10;
                    sum = sum + (rem * rem);
                    num = num / 10;
                }
                return sum;
            }

            private static void Main(string[] args)
            {
                Console.WriteLine("Enter a number: ");
                var num = Convert.ToInt32(Console.ReadLine());
                int result = num;

                while (result != 1 && result != 4)
                {
                    result = isHappyNumber(result);
                }

                if (result == 1)
                {
                    Console.WriteLine(num + " is a Happy number");
                }
                else if (result == 4)
                {
                    Console.WriteLine(num + " is not a Happy number");
                }
            }
        }
    }
}