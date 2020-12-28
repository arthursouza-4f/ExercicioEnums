using System;
using ExercicioPropostoCsharp.Entities.Enums;
using ExercicioPropostoCsharp.Entities;
using System.Collections.Generic;
namespace ExercicioPropostoCsharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client1 = new Client();
            OrderItem orderItem1  = new OrderItem();
            Order order = new Order();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime btd = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: (PendingPayment/Processsing/Shiped/Delivered);");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int pedidos = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, btd);

            for(int i = 0; i < pedidos; i++)
            {

                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string produtcName = Console.ReadLine();
                Console.Write("Product price: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                OrderItem orderItem  = new OrderItem(quantity, preco, produtcName);

            }

            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine("Order moment: ");
            Console.WriteLine(DateTime.Now);
            Console.Write("Order status: ");
            Console.WriteLine(OrderStatus.Processsing);
            Console.WriteLine("Client:");
            Console.WriteLine(client1);
            Console.WriteLine("Order item: ");
            Console.WriteLine(orderItem1);
            Console.WriteLine("Total Price: ");
            Console.WriteLine(order);
        }
    }
}
