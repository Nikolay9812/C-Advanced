using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> records = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                List<string> info = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string color = info[0];
                string[] items = info[1].Split(",");

                if (!records.ContainsKey(color))
                {
                    records.Add(color, new Dictionary<string, int>());
                }

                foreach (var item in items)
                {
                    if (!records[color].ContainsKey(item))
                    {
                        records[color].Add(item, 1);
                    }
                    else
                    {
                        records[color][item]++;
                    }
                }

            }

            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var color in records)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (color.Key == input[0] && item.Key == input[1])
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
