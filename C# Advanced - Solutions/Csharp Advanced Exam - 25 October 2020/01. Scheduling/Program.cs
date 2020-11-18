using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int taskToBeKilled = int.Parse(Console.ReadLine());

            Stack<int> taskValue = new Stack<int>(arr1);
            Queue<int> threadValue = new Queue<int>(arr2);

            while (true)
            {
                int thread = threadValue.Peek();
                int task = taskValue.Peek();

                if (taskToBeKilled == task)
                {
                    break;
                }

                if (thread >= task)
                {
                    threadValue.Dequeue();
                    taskValue.Pop();
                }
                else
                {
                    threadValue.Dequeue();
                }
            }

            Console.WriteLine($"Thread with value {threadValue.Peek()} killed task {taskToBeKilled}");
            Console.WriteLine(string.Join(" ", threadValue));
        }
    }
}
