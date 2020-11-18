using System;
using System.IO;

namespace _01._Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../input.txt");

            string[] newLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    newLines[i] += lines[i];
                }
            }

            File.WriteAllLines("../../../Output.txt", newLines);
        }
    }
}
