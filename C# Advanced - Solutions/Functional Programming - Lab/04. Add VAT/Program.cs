using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n + n * 0.2)
                .ToList()
                .ForEach(w => Console.WriteLine($"{w:f2}"));
        }
    }
}
