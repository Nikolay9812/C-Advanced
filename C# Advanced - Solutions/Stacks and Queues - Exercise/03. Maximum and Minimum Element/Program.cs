﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            while (n!=0)
            {
                int[] command = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (command[0] == 1)
                {
                    int number = command[1];
                    stack.Push(number);
                }
                else if (command[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else if (command[0] == 3)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command[0] == 4)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
                n--;
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
