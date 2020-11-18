using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());

            Queue<int[]> queue = new Queue<int[]>();

            FillQueue(pumps, queue);

            int count = 0;

            while (true)
            {
                int fuelAmount = 0;
                bool toBreak = true;

                for (int i = 0; i < pumps; i++)
                {
                    int[] currentPump = queue.Dequeue();

                    fuelAmount += currentPump[0];

                    if (fuelAmount < currentPump[1])
                    {
                        toBreak = false;
                    }

                    fuelAmount -= currentPump[1];

                    queue.Enqueue(currentPump);
                }

                if (toBreak)
                {
                    break;
                }

                count++;

                queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine(count);
        }

        private static void FillQueue(int pumps, Queue<int[]> queue)
        {
            for (int i = 0; i < pumps; i++)
            {
                int[] petrolPumpData = Console.ReadLine().Split().Select(int.Parse).ToArray();

                queue.Enqueue(petrolPumpData);
            }
        }
    }
}
