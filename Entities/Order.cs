using Composicao_fixacao2.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Cliente.Name + " (" + Cliente.BirthDate.ToString("dd/MM/yyyy") + ") - " + Cliente.Email);
            sb.AppendLine("Order Itens:");
            foreach (OrderItem oi in Pedido_itens)
            {
                sb.AppendLine(oi.ToString());
            }
            sb.AppendLine("Total price: $" + total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
