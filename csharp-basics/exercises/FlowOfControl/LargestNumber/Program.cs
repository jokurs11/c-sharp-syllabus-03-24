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

            int ParsedInput1 = int.Parse(input1);
            int ParsedInput2 = int.Parse(input2);
            int ParsedInput3 = int.Parse(input3);

            if (parsedInt1 > parsedInt2 && parsedInt1 > parsedInt3)
            {
                Console.WriteLine("Largest number is first: " + parsedInput1);
            } 
            else if (parsedInt2 > parsedInt1 && parsedInt2 > parsedInt3)
            {
                Console.WriteLine("Largest number is second: " + parsedIput2);
            }
            else
            {
                Console.WriteLine("Largest number is third: " + parsedInput3);
            }

        }
    }
}
