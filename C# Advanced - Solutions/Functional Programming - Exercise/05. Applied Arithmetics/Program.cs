using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Applied_Arithmetics
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

            Func<List<int>, List<int>> add = x => x.Select(x => ++x).ToList();
            Func<List<int>, List<int>> multiply = x => x.Select(x => x * 2).ToList();
            Func<List<int>, List<int>> subtract = x => x.Select(x => --x).ToList();
            Func<List<int>, string> print = x => string.Join(" ", x);

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        numbers = add(numbers);
                        break;
                    case "multiply":
                        numbers = multiply(numbers);
                        break;
                    case "subtract":
                        numbers = subtract(numbers);
                        break;
                    case "print":
                        Console.WriteLine(print(numbers));
                        break;
                }
            }
        }
    }
}
