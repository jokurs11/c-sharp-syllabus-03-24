using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private Money _amount;
        private List<Product> _products;

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
            _amount = new Money { Euros = 0, Cents = 0 };
            _products = new List<Product>();
        }

        public string Manufacturer { get; private set; }

        public bool HasProducts
        {
            get
            {
                for (int i = 0; i < _products.Count; i++)
                {
                    if (_products[i].Available > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public Money Amount
        {
            get
            {
                return _amount;
            }
        }

        public Product[] Products
        {
            get
            {
                Product[] productsArray = new Product[_products.Count];
                for (int i = 0; i < _products.Count; i++)
                {
                    productsArray[i] = _products[i];
                }
                return productsArray;
            }
        }

        private readonly List<decimal> validCoins = new List<decimal> { 0.10m, 0.20m, 0.50m, 1.00m, 2.00m };

        public Money InsertCoin(Money amount)
        {
            decimal coinValue = ConvertMoneyToDecimal(amount);

            bool isValidCoin = false;
            for (int i = 0; i < validCoins.Count; i++)
            {
                if (coinValue == validCoins[i])
                {
                    isValidCoin = true;
                    break;
                }
            }

            if (isValidCoin)
            {
                _amount = AddMoney(_amount, amount);
                return new Money { Euros = 0, Cents = 0 };
            }
            else
            {
                return amount;
            }
        }

        public Money ReturnMoney()
        {
            Money returnAmount = _amount;
            _amount = new Money { Euros = 0, Cents = 0 };
            return returnAmount;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            if (count > 0)
            {
                Product product = new Product
                {
                    Name = name,
                    Price = price,
                    Available = count
                };
                _products.Add(product);
                return true;
            }
            return false;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 || productNumber >= _products.Count)
            {
                return false;
            }

            Product product = _products[productNumber];

            if (!string.IsNullOrEmpty(name))
            {
                product.Name = name;
            }

            if (price.HasValue)
            {
                product.Price = price.Value;
            }

            if (amount >= 0)
            {
                product.Available = amount;
            }

            _products[productNumber] = product;

            return true;
        }

        public bool PurchaseProduct(int productIndex)
        {
            if (productIndex < 0 || productIndex >= _products.Count)
            {
                Console.WriteLine("Invalid product selected.");
                return false;
            }

            Product product = _products[productIndex];

            decimal productPrice = ConvertMoneyToDecimal(product.Price);
            decimal userAmount = ConvertMoneyToDecimal(_amount);

            if (product.Available <= 0)
            {
                Console.WriteLine("Sorry, the product is out of stock.");
                return false;
            }

            if (userAmount >= productPrice)
            {
                product.Available--;
                _products[productIndex] = product;

                decimal change = userAmount - productPrice;
                _amount = new Money { Euros = 0, Cents = 0 };

                if (change > 0)
                {
                    Console.WriteLine($"Product dispensed: {product.Name}. " +
                        $"Returning change: {change:F2} EUR");
                }
                else
                {
                    Console.WriteLine($"Product dispensed: {product.Name}. No change.");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient money. Please insert more coins.");
                return false;
            }
        }

        private decimal ConvertMoneyToDecimal(Money money)
        {
            return money.Euros + money.Cents / 100m;
        }

        private Money AddMoney(Money current, Money add)
        {
            int totalCents = current.Cents + add.Cents;
            int totalEuros = current.Euros + add.Euros + totalCents / 100;
            totalCents = totalCents % 100;
            return new Money { Euros = totalEuros, Cents = totalCents };
        }
    }
}