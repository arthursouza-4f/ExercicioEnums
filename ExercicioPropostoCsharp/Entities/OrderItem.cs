namespace ExercicioPropostoCsharp.Entities
{
    class OrderItem
    {

        public int Quantity { get; set; }

        public double Price { get; set; }
        
        public string Name { get; set; }





        public OrderItem()
        {
        }

        public OrderItem(int quantidade, double price, string name)
        {
            Quantity = quantidade;
            Price = price;
            Name = name;
        }

        public double subTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Name
            + ", "
            + Price
            + "Quantity: "
            + Quantity
            + ", "
            + "SubTotal: "
            + subTotal();



        }

    }
}
