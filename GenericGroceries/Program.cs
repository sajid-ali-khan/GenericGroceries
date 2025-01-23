using System;
using GenericGroceries;

Console.WriteLine("What do you want to shop for?");
Console.WriteLine("1. Eggs\n2. Vegetables\n3. Both");

switch (Console.ReadLine())
{
    case "1":
        Console.WriteLine("Shopping for Eggs:");
        var eggShopping = new Shopping<Egg>();
        eggShopping.StartShopping();
        break;
    case "2":
        Console.WriteLine("\nShopping for Vegetables:");
        var vegetableShopping = new Shopping<Vegetable>();
        vegetableShopping.StartShopping();
        break;
}
