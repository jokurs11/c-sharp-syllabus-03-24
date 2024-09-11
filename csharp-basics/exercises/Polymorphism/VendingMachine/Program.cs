using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine("Simple Vendor");

            machine.AddProduct("Water", new Money { Euros = 1, Cents = 0 }, 5);
            machine.AddProduct("Soda", new Money { Euros = 1, Cents = 50 }, 3);
            machine.AddProduct("Chips", new Money { Euros = 0, Cents = 80 }, 10);

            while (true)
            {
                Console.WriteLine("Available Products:");
                var products = machine.Products;
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {products[i].Name} - " +
                        $"{products[i].Price.Euros}.{products[i].Price.Cents:D2} " +
                        $"EUR (Available: {products[i].Available})");
                }

                Console.WriteLine("Select a product by number (or type 'exit' to quit):");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                    break;
                }

                int productIndex;
                if (int.TryParse(input, out productIndex) && productIndex >= 1 &&
                    productIndex <= products.Length)
                {
                    productIndex--;

                    while (true)
                    {
                        Console.WriteLine($"Insert coins for {products[productIndex].Name}. " +
                            $"Total inserted: {machine.Amount.Euros}.{machine.Amount.Cents:D2} EUR");
                        Console.WriteLine("Valid coins are 0.10, 0.20, 0.50, 1.00, 2.00. " +
                            "Type 'done' when finished or 'return' to return money.");

                        string coinInput = Console.ReadLine();

                        if (coinInput.ToLower() == "done")
                        {
                            if (machine.PurchaseProduct(productIndex))
                            {
                                break;
                            }
                        }
                        else if (coinInput.ToLower() == "return")
                        {
                            Money returnedMoney = machine.ReturnMoney();
                            Console.WriteLine($"Returning {returnedMoney.Euros}.{returnedMoney.Cents:D2} " +
                                $"EUR.");
                            break;
                        }
                        else
                        {
                            if (decimal.TryParse(coinInput, out decimal coinValue))
                            {
                                int euros = (int)coinValue;
                                int cents = (int)((coinValue - euros) * 100);
                                Money coin = new Money { Euros = euros, Cents = cents };

                                Money returnedCoin = machine.InsertCoin(coin);

                                if (returnedCoin.Euros == 0 && returnedCoin.Cents == 0)
                                {
                                    Console.WriteLine("Coin accepted.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid coin. Please insert valid coins.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please insert a valid coin.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product number.");
                }
            }
        }
    }
}

