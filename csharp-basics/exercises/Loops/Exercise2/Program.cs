using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of terms : ");
            var n = Convert.ToInt32(Console.ReadLine());
            var result = 0;
            for (var i = 1; i <= n; i++)
            {
                result = i * n;
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}