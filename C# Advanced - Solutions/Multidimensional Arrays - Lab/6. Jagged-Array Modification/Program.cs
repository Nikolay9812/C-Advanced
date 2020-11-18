using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggArray = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                jaggArray[row] = currentRow;
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row < 0 || row >= jaggArray.Length || col < 0 || col >= jaggArray[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggArray[row][col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row < 0 || row >= jaggArray.Length || col < 0 || col >= jaggArray[row].Length)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        jaggArray[row][col] -= value;
                    }

                }
                else if (command[0] == "END")
                {
                    break;
                }
            }

            foreach (var item in jaggArray)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
