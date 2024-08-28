using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first number");
            var num1 = Console.ReadLine();

            Console.WriteLine("Input the operator (select from +, -, * or /)");
            var symbol = Console.ReadLine();

            Console.WriteLine("Input second number");
            var num2 = Console.ReadLine();

            var decimalNum1 = decimal.Parse(num1);
            var decimalNum2 = decimal.Parse(num2);


            if (symbol == "/")
            {
                var output = decimalNum1 / decimalNum2;
                Console.WriteLine("The result is: " + output);
            }
            else if (symbol == "+")
            {
                var output = decimalNum1 + decimalNum2;
                Console.WriteLine("The result is: " + output);
            }
            else if (symbol == "-")
            {
                var output = decimalNum1 - decimalNum2;
                Console.WriteLine("The result is: " + output);
            }
            else if (symbol == "*")
            {
                var output = decimalNum1 * decimalNum2;
                Console.WriteLine("The result is: " + output);
            }
            else
            {
                Console.WriteLine("Enter valid operator");
            }
        }
    }
}