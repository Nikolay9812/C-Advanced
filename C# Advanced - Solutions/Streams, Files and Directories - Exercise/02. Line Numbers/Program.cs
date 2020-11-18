using System;
using System.IO;
using System.Linq;

namespace _02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../text.txt");

            string[] newLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int letters = LetterCounter(line);
                int marks = PunctuationMarksCounter(line);

                newLines[i] = $"Line {i + 1}: {lines[i]} ({letters})({marks})";
            }

            File.WriteAllLines("../../../output.txt", newLines);
        }

        static int LetterCounter(string line)
        {
            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];
                if (char.IsLetter(symbol))
                {
                    counter++;
                }
            }

            return counter;
        }

        static int PunctuationMarksCounter(string line)
        {
            char[] punctuationMarks = { '-', ',', '.', '!', '?', '\'' };


            int counter = 0;

            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];
                if (punctuationMarks.Contains(symbol))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
