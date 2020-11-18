using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> listOfNames =
                Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Predicate<string> predicate = x => x.Length <= n;
            Func<string, bool> func = x => predicate(x);

            listOfNames = listOfNames.Where(func).ToList();

            foreach (var name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
