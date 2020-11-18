using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> records = new Dictionary<string, Dictionary<string, List<string>>>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!records.ContainsKey(continent))
                {
                    records.Add(continent, new Dictionary<string, List<string>>());
                }

                if (!records[continent].ContainsKey(country))
                {
                    records[continent].Add(country, new List<string>());
                }

                records[continent][country].Add(city);
            }

            foreach (var continent in records)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
