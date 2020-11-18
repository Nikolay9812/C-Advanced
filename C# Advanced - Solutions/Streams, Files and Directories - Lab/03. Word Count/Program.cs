using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            using (StreamReader wordsReader = new StreamReader("../../../words.txt"))
            {
                while (true)
                {
                    string wordsLine = wordsReader.ReadLine();
                    if (wordsLine == null)
                    {
                        break;
                    }

                    string[] wordsArr = wordsLine
                        .Split()
                        .ToArray();

                    foreach (var item in wordsArr)
                    {
                        if (!words.ContainsKey(item))
                        {
                            words.Add(item, 0);
                        }
                    }
                }
            }

            char[] delimiters = new char[] { ' ', ',', '.', '!', '-', '?', ':', };

            using (StreamReader textReader = new StreamReader("../../../text.txt"))
            {
                while (true)
                {
                    string textLine = textReader.ReadLine();
                    if (textLine == null)
                    {
                        break;
                    }

                    string[] textArr = textLine
                        .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    foreach (var item in textArr)
                    {
                        if (words.ContainsKey(item))
                        {
                            words[item]++;
                        }
                    }
                }
            }

            using (StreamWriter outputWriter = new StreamWriter("../../../Output.txt"))
            {
                foreach (var item in words.OrderByDescending(x => x.Value))
                {
                    outputWriter.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}