using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsAndCols[0];
            int cols = rowsAndCols[1];

            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();

            int counter = 0;

            Queue<char> myQue = new Queue<char>();

            int capacity = rows * cols;

            for (int i = 0; i < snake.Length; i++)
            {
                myQue.Enqueue(snake[i]);
                counter++;

                if (counter == capacity)
                {
                    break;
                }
                if (i == snake.Length - 1)
                {
                    i = -1;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = myQue.Dequeue();
                    }
                }
                else if (row % 2 != 0)
                {
                    for (int i = cols - 1; i > -1; i--)
                    {
                        matrix[row, i] = myQue.Dequeue();
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}
