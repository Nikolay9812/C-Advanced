using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> foodShops = new Dictionary<string, Dictionary<string, double>>();

            string command;

            while ((command = Console.ReadLine()) != "Revision")
            {
                string[] input = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!foodShops.ContainsKey(shop))
                {
                    foodShops.Add(shop, new Dictionary<string, double>());
                }
                if (!foodShops[shop].ContainsKey(product))
                {
                    foodShops[shop].Add(product,0);
                }

                foodShops[shop][product] = price;
            }

            foreach (var item in foodShops.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var second in item.Value)
                {
                    Console.WriteLine($"Product: {second.Key}, Price: {second.Value}");
                }
            }
        }
    }
}
