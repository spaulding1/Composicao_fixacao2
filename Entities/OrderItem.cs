using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao_fixacao2.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public List<Product> produtos = new List<Product>();

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }
    }
}
