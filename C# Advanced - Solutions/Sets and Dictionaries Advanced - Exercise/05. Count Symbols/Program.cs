using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> records = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!records.ContainsKey(input[i]))
                {
                    records.Add(input[i], 1);
                }
                else
                {
                    records[input[i]]++;
                }
            }

            foreach (var item in records.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
