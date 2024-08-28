using System;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };
            bool found = false;
            
            foreach (int num in myArray)
            {
                if (num == 1245)
                {
                    found = true;
                    Console.WriteLine("Contains!");
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Does not contain 1245!");
            }
        }
    }
}