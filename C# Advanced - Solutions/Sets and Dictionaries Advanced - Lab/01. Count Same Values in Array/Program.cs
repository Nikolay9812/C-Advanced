using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] array = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(decimal.Parse)
                 .ToArray();

            Dictionary<decimal, int> dictionary = new Dictionary<decimal, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (!dictionary.ContainsKey(array[i]))
                {
                    dictionary.Add(array[i], 1);
                }
                else
                {
                    dictionary[array[i]]++;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
