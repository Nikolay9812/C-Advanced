using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01.__Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader streamReader = new StreamReader("../../../text.txt");

            string line = streamReader.ReadLine();
            int counter = 0;

            while (line != null)
            {

                if (counter % 2 == 0)
                {
                    Regex pattern = new Regex(@"[\-\,\.\!\?]");
                    line = pattern.Replace(line, "@");

                    var reversedLine = line.Split().ToArray().Reverse();
                    Console.WriteLine(string.Join(" ", reversedLine));
                }
                counter++;
                line = streamReader.ReadLine();
            }
        }
    }
}
