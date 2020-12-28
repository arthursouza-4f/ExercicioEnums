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
           
              Order order = new Order();
            
             
            
            Console.Write("Name: ");
              string name = Console.ReadLine();
              Console.Write("Email: ");
              string email = Console.ReadLine();
              Console.Write("Birth date (DD/MM/YYYY): ");
              DateTime btd = DateTime.Parse(Console.ReadLine());
              Console.WriteLine("Enter order data: ");
              Console.Write("Status: (PendingPayment/Processsing/Shiped/Delivered): ");
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
                order.OrderItem.Add( new OrderItem(quantity, preco, produtcName));

            }
           
           



            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine("Order moment: ");
            Console.WriteLine(DateTime.Now);
            Console.Write("Order status: ");
            Console.WriteLine(status);
            Console.WriteLine("Client:");
            Console.WriteLine(client.ToString());
            Console.WriteLine("Order item: ");
            
            foreach (OrderItem item in order.OrderItem)
            {
                Console.WriteLine(item.ToString());
            }


            Console.Write("Total Price: ");
            Console.Write(order.ToString());
        }
    }
}
