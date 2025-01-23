namespace GenericGroceries
{
    public abstract class Grocery
    {
        public string Name { get; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string MeasuringScale { get; }

        public Grocery(string name, string measuringScale)
        {
            Name = name;
            MeasuringScale = measuringScale;
        }

        public abstract void DisplayDetails();
        public abstract void askQnty();
        public abstract void askPrice();
        public abstract int calculatePrice();
    }
}
