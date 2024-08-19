using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Console.ReadLine();

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Console.ReadLine();

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Console.ReadLine();

            int parsedInt1 = int.Parse(input1);

            int parsedInt2 = int.Parse(input2);

            int parsedInt3 = int.Parse(input3);



            if (parsedInt1 > parsedInt2 && parsedInt1 > parsedInt3)
            {
                Console.WriteLine("Largest number is first: " + parsedInt1);

            } 
            else if (parsedInt2 > parsedInt1 && parsedInt2 > parsedInt3)
            {
                Console.WriteLine("Largest number is second: " + parsedInt2);
            }
            else
            {
                Console.WriteLine("Largest number is third: " + parsedInt3);

            }

        }
    }
}
