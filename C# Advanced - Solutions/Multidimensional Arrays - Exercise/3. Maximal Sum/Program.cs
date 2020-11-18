using System;
using System.Linq;

namespace _3._Maximal_Sum
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

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = int.MinValue;
            int r = 0;
            int c = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row, col + 2] + matrix[row + 1, col]
                        + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1]
                        + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        r = row;
                        c = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            Console.WriteLine($"{matrix[r, c]} {matrix[r, c + 1]} {matrix[r, c + 2]}");
            Console.WriteLine($"{matrix[r + 1, c]} {matrix[r + 1, c + 1]} {matrix[r + 1, c + 2]}");
            Console.WriteLine($"{matrix[r + 2, c]} {matrix[r + 2, c + 1]} {matrix[r + 2, c + 2]}");
        }
    }
}
