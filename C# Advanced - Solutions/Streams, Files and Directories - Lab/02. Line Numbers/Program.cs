using System;
using System.IO;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../input.txt");

            string[] newLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                newLines[i] = $"{i + 1}.  {lines[i]}";
            }

            File.WriteAllLines("../../../Output.txt", newLines);

        }
    }
}
