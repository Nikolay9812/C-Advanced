using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            HashSet<int> topRecords = new HashSet<int>();
            HashSet<int> bottomRecords = new HashSet<int>();

            for (int i = 0; i < n[0]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                topRecords.Add(number);
            }
            for (int i = 0; i < n[1]; i++)
            {
                int number = int.Parse(Console.ReadLine());
                bottomRecords.Add(number);
            }

            List<int> numbers = new List<int>();

            foreach (var item1 in topRecords)
            {
                foreach (var item2 in bottomRecords)
                {
                    if (item1 == item2)
                    {
                        numbers.Add(item1);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
