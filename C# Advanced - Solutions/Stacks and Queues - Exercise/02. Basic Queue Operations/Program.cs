using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nxs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = nxs[0];
            int s = nxs[1];
            int x = nxs[2];

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> stack = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Dequeue();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count != 0)
                {
                    Console.WriteLine(stack.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
