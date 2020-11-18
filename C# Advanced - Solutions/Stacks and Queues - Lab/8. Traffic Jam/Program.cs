using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> queue = new Queue<string>();

            int count = 0;

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    int carsCount = queue.Count;

                    for (int i = 0; i < Math.Min(carsCount, n); i++)
                    {
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        count++;
                    }

                }
                else
                {
                    queue.Enqueue(input);
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
