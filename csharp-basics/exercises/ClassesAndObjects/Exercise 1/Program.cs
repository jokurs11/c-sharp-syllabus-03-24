using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Check Logitech mice: 1");
                Console.WriteLine("Check iPhones: 2");
                Console.WriteLine("Check Epson printers: 3");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Logitech();
                        break;
                    case 2:
                        IPhone();
                        break;
                    case 3:
                        Epson();
                        break;
                    default:
                        return;
                }
            } while (true);
        }

        private static Product mouse = new Product("Logitech mouse", 70.00, 14);

        private static void Logitech()
        {
            mouse.PrintProduct();

            Console.WriteLine("Change the inventory quantity: ");

            var changingQuantity1 = int.Parse(Console.ReadLine());

            mouse.ChangeQuantity(changingQuantity1);
            mouse.PrintProduct();

            Console.WriteLine("Change the price: ");

            var changingPrice = Convert.ToDouble(Console.ReadLine());

            mouse.ChangePrice(changingPrice);
            mouse.PrintProduct();
        }

        private static Product iPhone = new Product("iPhone 5s", 999.99, 3);

        private static void IPhone()
        {
            iPhone.PrintProduct();

            Console.WriteLine("Change the inventory quantity: ");

            var changingQuantity2 = int.Parse(Console.ReadLine());

            iPhone.ChangeQuantity(changingQuantity2);
            iPhone.PrintProduct();

            Console.WriteLine("Change the price: ");

            var changingPrice = Convert.ToDouble(Console.ReadLine());

            iPhone.ChangePrice(changingPrice);
            iPhone.PrintProduct();

        }

        private static Product epson = new Product("Epson EB-U05", 440.46, 1);

        private static void Epson()
        {
            epson.PrintProduct();

            Console.WriteLine("Change the inventory quantity: ");

            var changingQuantity = int.Parse(Console.ReadLine());

            epson.ChangeQuantity(changingQuantity);
            epson.PrintProduct();

            Console.WriteLine("Change the price: ");

            var changingPrice = Convert.ToDouble(Console.ReadLine());

            epson.ChangePrice(changingPrice);
            epson.PrintProduct();
        }
    }
}
