using Composicao_fixacao2.Entities;
using Composicao_fixacao2.Entities.Enums;
using System;
using System.Globalization;

namespace Composicao_fixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data:");
            Console.Write("Name: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client cliente = new Client(nome, email, birthdate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, cliente);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter " + i + " item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Product produto = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int qtt = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qtt, productPrice, produto);

                order.addItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
