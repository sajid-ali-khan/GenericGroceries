using System;
using System.Xml.Linq;

namespace GenericGroceries
{
    class Egg : Grocery
    {
        public Egg(int quantity, int price)
            : base("Egg", "dozens")
        {
            Quantity = quantity;
            Price = price;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Item: {Name}");
            Console.WriteLine($"Quantity: {Quantity} {MeasuringScale}");
            Console.WriteLine($"Price: ${calculatePrice()}");
        }

        public override int calculatePrice()
        {
            return 12 * Quantity * Price;
        }

        public override void askQnty()
        {
            Console.WriteLine("How many dozens of eggs do you want?");
        }

        public override void askPrice()
        {
            Console.WriteLine("Price of each egg?");
        }
    }
}