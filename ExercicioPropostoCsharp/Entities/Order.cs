using System;
using System.Collections.Generic;
using System.Text;
using ExercicioPropostoCsharp.Entities.Enums;
namespace ExercicioPropostoCsharp.Entities


{
    class Order
    {

        public DateTime Moment { get; set; }

        public OrderStatus  Status { get; set; }

        public Client Client { get; set; }

        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client Client)
        {
            Moment = moment;
            Status = status;
            Client = Client;
        }




     
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in OrderItem)
            {
                sum += item.subTotal();
            };

            return sum;

        }

        public override string ToString()
        {
            return Total().ToString();
        }



    }
}
