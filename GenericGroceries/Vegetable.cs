using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericGroceries
{
    internal class Vegetable : Grocery
    {
        public Vegetable(string name, int quantity, int price) : base(name, "Kilos")
        {
            this.Price = price;
            this.Quantity = quantity;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Item: {Name}");
            Console.WriteLine($"Quantity: {Quantity} {MeasuringScale}");
            Console.WriteLine($"Price: ${calculatePrice()}");
        }

        public override void askQnty()
        {
            Console.WriteLine($"How many {MeasuringScale} of {Name} do you want?");
        }

        public override int calculatePrice()
        {
            return Price * Quantity;
        }

        public override void askPrice()
        {
            Console.WriteLine($"Whats the price of 1 {MeasuringScale} of {Name}?");
        }
    }
}
