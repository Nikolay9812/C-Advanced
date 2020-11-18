using System;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static byte rows;
        static byte cols;
        static char[][][] matrix;
        static byte pRow;
        static byte pCol;
        static bool live = true;
        static bool win = false;

        static void Main(string[] args)
        {
            byte[] nxm = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(byte.Parse)
                .ToArray();
            rows = nxm[0];
            cols = nxm[1];
            matrix = new char[rows][][];
            for (byte row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols][];
                char[] input = Console.ReadLine()
                    .ToCharArray();
                for (byte col = 0; col < cols; col++)
                {
                    matrix[row][col] = new char[2];
                    matrix[row][col][0] = input[col];
                    if (input[col] == 'P')
                    {
                        pRow = row;
                        pCol = col;
                    }
                    else if (input[col] == 'B')
                    {
                        matrix[row][col][1] = input[col];
                    }
                }
            }
            string comm = Console.ReadLine();
            foreach (var cha in comm)
            {
                Move(cha);
                Spare();
                OldB();
                if (win)
                {
                    Print();
                    Console.WriteLine($"won: {pRow} {pCol}");
                    break;
                }
                if (!live)
                {
                    Print();
                    Console.WriteLine($"dead: {pRow} {pCol}");
                    break;
                }
            }
        }
        private static void OldB()
        {
            for (byte row = 0; row < rows; row++)
            {
                for (byte col = 0; col < cols; col++)
                {
                    if (matrix[row][col][0] == 'B')
                    {
                        matrix[row][col][1] = 'B';
                    }
                }
            }
        }
        private static void Spare()
        {
            for (byte row = 0; row < rows; row++)
            {
                for (byte col = 0; col < cols; col++)
                {
                    if (matrix[row][col][1] == 'B')
                    {
                        byte ro = row;
                        byte co = col;
                        Buni(--ro, co);
                        ro = row;
                        Buni(ro, ++co);
                        co = col;
                        Buni(++ro, co);
                        ro = row;
                        Buni(ro, --co);
                    }
                }
            }
        }
        private static void Buni(byte r, byte c)
        {
            if (IsIn(r, c))
            {
                if (matrix[r][c][0] == 'P') live = false;
                matrix[r][c][0] = 'B';
            }
        }
        private static void Move(char ch)
        {
            switch (ch)
            {
                case 'U':
                    byte ro = pRow;
                    Direkt(--ro, pCol);
                    break;
                case 'D':
                    ro = pRow;
                    Direkt(++ro, pCol);
                    break;
                case 'R':
                    byte co = pCol;
                    Direkt(pRow, ++co);
                    break;
                case 'L':
                    co = pCol;
                    Direkt(pRow, --co);
                    break;
            }
        }
        private static void Direkt(byte r, byte c)
        {
            matrix[pRow][pCol][0] = '.';
            if (IsIn(r, c))
            {
                if (matrix[r][c][0] == 'B')
                    live = false;
                else
                    matrix[r][c][0] = 'P';
                pRow = r;
                pCol = c;
            }
            else
                win = true;
        }
        static bool IsIn(byte r, byte c)
        {
            if (r >= 0 && r < rows && c >= 0 && c < cols)
                return true;
            else
                return false;
        }
        private static void Print()
        {
            for (byte row = 0; row < rows; row++)
            {
                for (byte col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row][col][0]}");
                }
                Console.WriteLine();
            }
        }
    }
}
