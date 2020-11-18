using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(numbers);

            int count = 0;

            while (stack.Count != 0)
            {
                int sum = 0;

                while (true)
                {
                    sum += stack.Pop();

                    if (sum == capacity)
                    {
                        break;
                    }
                    if (stack.Count != 0)
                    {
                        if (sum + stack.Peek() > capacity)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                count++;

            }

            Console.WriteLine(count);
            Console.WriteLine(string.Join(" ", stack));
        }
    }
}
