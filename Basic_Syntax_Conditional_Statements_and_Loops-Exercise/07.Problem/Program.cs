using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double cost = 0;
            double coins = 0;
            double total = 0;
            while (input != "Start")
            {
                coins = double.Parse(input);
                bool validCoins = coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2;
                if (validCoins)
                {

                    total += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                switch (product)
                {
                    case "Nuts":
                        cost = 2.0;
                        break;
                    case "Water":
                        cost = 0.7;
                        break;
                    case "Crisps":
                        cost = 1.5;
                        break;
                    case "Soda":
                        cost = 0.8;
                        break;
                    case "Coke":
                        cost = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }
                if (total >= cost)
                {
                    Console.WriteLine($"Purchased {product.ToLower()}");
                    total -= cost;
                    cost = 0;
                }
                else if (cost > total)
                {
                    Console.WriteLine("Sorry, not enough money");
                    cost = 0;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {total:F2}");

        }
    }
}
