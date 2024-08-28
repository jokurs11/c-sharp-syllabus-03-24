using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var choise = GetMenu();
            switch (choise)
            {
                case 1:
                    CalculateCircleArea();
                    break;
                case 2:
                    CalculateRectangleArea();
                    break;
                case 3:
                    CalculateTriangleArea();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("No such choise");
                    break;
            }

        }

        public static int GetMenu()
        {
            int userChoice;


            // Display the menu.
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadKey();

            userChoice = int.Parse(keyboard.KeyChar.ToString());


            return userChoice;
        }

        public static void CalculateCircleArea()
        {

            Console.WriteLine(" ");
            Console.WriteLine("What is the circle's radius? ");

            var radius = double.Parse(Console.ReadLine());


            Console.WriteLine("The circle's area is "
                    + Geometry.AreaOfCircle(radius));
        }

        public static void CalculateRectangleArea()
        {
            double length = 0;
            double width = 0;
          
            Console.WriteLine(" ");

            Console.WriteLine("Enter length? ");

            length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter width? ");

            width = double.Parse(Console.ReadLine());

            Console.WriteLine("The rectangle's area is "
                    + Geometry.AreaOfTriangle(length, width));
        }

        public static void CalculateTriangleArea()
        {
            double ground = 0;
            double height = 0;



            Console.WriteLine(" ");
            Console.WriteLine("Enter length of the triangle's base? ");
            var input = Console.ReadLine();
            ground = double.Parse(input);
            var testGround = Convert.ToDouble(input);




            Console.WriteLine("Enter triangle's height? ");

            input = Console.ReadLine();
            height = double.Parse(input);


            Console.WriteLine("The triangle's area is "
                    + Geometry.AreaOfRectangle(ground, height));
        }
    }
}