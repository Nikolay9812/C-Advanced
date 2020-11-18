using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine().Split(", ").ToArray();

            Queue<string> queue = new Queue<string>(songs);

            string command;
            while (true)
            {
                while ((command = Console.ReadLine()) != "Show")
                {
                    if (command.Contains("Play"))
                    {

                        queue.Dequeue();

                        if (queue.Count == 0)
                        {
                            Console.WriteLine("No more songs!");
                            return;
                        }

                    }
                    else if (command.Contains("Add"))
                    {
                        string song = command.Remove(0, 4);

                        if (!queue.Contains(song))
                        {
                            queue.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                    }
                }

                Console.WriteLine(string.Join(", ", queue));
            }
        }
    }
}
