using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public abstract class Food
    {
        public int _quantity { get; set; }
        public Food(int quantity)
        {
            _quantity = quantity;
        }
    }
}