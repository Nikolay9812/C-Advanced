using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>(numbers);

            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] element = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (element[0] == "add")
                {
                    int firstNum = int.Parse(element[1]);
                    int secondNum = int.Parse(element[2]);

                    stack.Push(firstNum);
                    stack.Push(secondNum);
                }
                else if (element[0] == "remove")
                {
                    int count = int.Parse(element[1]);

                    if (count >= 0 && count < stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }

                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
