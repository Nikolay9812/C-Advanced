using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = x => char.IsUpper(x[0]);

            Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Where(func)
                 .ToList()
                 .ForEach(x => Console.WriteLine(x));
        }
    }
}
