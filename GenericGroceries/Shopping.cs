using System;
using System.Collections.Generic;
using System.Threading;

namespace GenericGroceries
{
    public abstract class Shopping<T> where T: Grocery
    {
        private List<T> groceryList;
        private int total;

        public Shopping()
        {
            groceryList = new List<T>();
            total = 0;
        }

        public void StartShopping()
        {
            AddItems();
            AskQuantitiesAndPrices();
            CalculateTotal();
            ShowGroceryDetails();
        }

        public abstract void AddItem(T item)
        {
            groceryList.Add(item);
            Console.WriteLine($"\nAdded {item.Name} to the grocery list.\n");
            Thread.Sleep(200);
        }

        private abstract void AddItems()
        {
            Console.WriteLine("Adding items to the grocery list...");
            Console.WriteLine("You can add multiple items of type: " + typeof(T).Name);

            while (true)
            {
                if (typeof(T) == typeof(Egg))
                {
                    AddItem((T)(object)new Egg(0, 0));
                    break;
                }
                else if (typeof(T) == typeof(Vegetable))
                {
                    Console.WriteLine("\nVegetable Name: ");
                    string name = Console.ReadLine()!;
                    AddItem((T)(object)new Vegetable(name, 0, 0));
                }

                Console.WriteLine("Want to add more items? (y/n)");
                if (Console.ReadLine()!.ToLower() == "n") break;
            }
        }

        private abstract void AskQuantitiesAndPrices()
        {
            foreach (var item in groceryList)
            {
                item.askQnty();
                int qnty = int.Parse(Console.ReadLine()!);

                item.askPrice();
                int price = int.Parse(Console.ReadLine()!);

                item.Quantity = qnty;
                item.Price = price;
                Console.WriteLine();
            }
        }

        private abstract void CalculateTotal()
        {
            Console.WriteLine("Calculating the total...");
            Thread.Sleep(2000);
            foreach (var item in groceryList)
            {
                total += item.calculatePrice();
            }
        }

        private abstract void ShowGroceryDetails()
        {
            Console.WriteLine("\n---- Grocery List Details ----");
            foreach (var item in groceryList)
            {
                item.DisplayDetails();
            }
            Console.WriteLine($"\nTotal Amount: ${total}");
        }
    }
}
