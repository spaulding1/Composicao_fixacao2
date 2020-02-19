using Composicao_fixacao2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao_fixacao2.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Cliente { get; set; }
        public List<OrderItem> Pedido_itens { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client cliente)
        {
            Moment = moment;
            Status = status;
            Cliente = cliente;
        }

        public void addItem(OrderItem item)
        {
            Pedido_itens.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            Pedido_itens.Remove(item);
        }

        public double total()
        {
            double soma = 0.0;
            foreach (OrderItem oi in Pedido_itens)
            {
                soma += oi.subTotal();
            }
            return soma;
        }
    }
}
