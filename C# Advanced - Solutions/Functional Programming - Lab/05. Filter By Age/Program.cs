using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> records = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = info[0];
                int currAge = int.Parse(info[1]);

                records.Add(name, currAge);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            foreach (var person in records)
            {
                if (condition == "younger" && age > person.Value)
                {
                    if (format == "name")
                    {
                        Console.WriteLine(person.Key);
                    }
                    else if (format == "age")
                    {
                        Console.WriteLine(person.Value);
                    }
                    else if (format == "name age")
                    {
                        Console.WriteLine($"{person.Key} - {person.Value}");
                    }
                }
                else if (condition == "older" && age <= person.Value)
                {
                    if (format == "name")
                    {
                        Console.WriteLine(person.Key);
                    }
                    else if (format == "age")
                    {
                        Console.WriteLine(person.Value);
                    }
                    else if (format == "name age")
                    {
                        Console.WriteLine($"{person.Key} - {person.Value}");
                    }
                }
            }
        }
    }
}
