using System;
using System.Linq;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray(); ;

            int rows = size[0];
            int cols = size[1];

            int[,] garden = new int[rows, cols];

            string command;

            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                string[] element = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    int rowIndex = int.Parse(element[0]);
                    int colIndex = int.Parse(element[1]);
                    garden[rowIndex, colIndex] = -1;

                    for (int row = 0; row < garden.GetLength(0); row++)
                    {
                        garden[row, colIndex]++;
                    }
                    for (int col = 0; col < garden.GetLength(1); col++)
                    {
                        garden[rowIndex, col]++;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid coordinates.");
                }

            }

            for (int row = 0; row < garden.GetLength(0); row++)
            {
                for (int col = 0; col < garden.GetLength(1); col++)
                {
                    Console.Write(garden[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
