using System;
using System.Xml.Linq;

namespace Exercise1
{
    class Product
    {
        public string _item;
        public double _price;
        public int _amount;

        public Product(string anItem, double aPrice, int anAmount)
        {
            _item = anItem;
            _price = aPrice;
            _amount = anAmount;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{_item}, {_price} EUR, {_amount} units");
        }

        public void ChangeQuantity(int newAmount)
        {
            _amount = newAmount;
            Console.WriteLine($"The {_item} amount is changed to {_amount}");
        }
        public void ChangePrice(double newPrice)
        {

            _price = newPrice;
            Console.WriteLine($"The {_item} price is changed to " + $"{_price:0.00}");
        }
    }
}