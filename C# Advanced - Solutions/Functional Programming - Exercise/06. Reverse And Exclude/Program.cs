using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers =
                Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int n = int.Parse(Console.ReadLine());

            Predicate<int> predicate = x => x % n != 0;
            Func<int, bool> func = x => predicate(x);

            numbers = numbers.Where(func).Reverse().ToList();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
