using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>(numbers);

            Console.WriteLine(numbers.Max());

            while (true)
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
                if (quantity >= queue.Peek())
                {
                    quantity -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
        }
    }
}
