using System;

namespace ProductToN
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int limit = 10;
            for (int i = 1; i <= limit; i++)
            {
                count = count * i;
            }
            Console.WriteLine("The product of 1 to " + limit + " is " + count);
        }
    }
}