using System;
using System.Threading;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Convert.ToInt64(Console.ReadLine());

            var inputParsed = Math.Abs(input);



            int count = 0;

            while (inputParsed > 0)
            {
                inputParsed = inputParsed / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
