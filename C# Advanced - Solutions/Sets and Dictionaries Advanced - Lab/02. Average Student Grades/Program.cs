using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsRecords = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < students; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = info[0];
                decimal grade = decimal.Parse(info[1]);

                if (studentsRecords.ContainsKey(name))
                {
                    studentsRecords[name].Add(grade);
                }
                else
                {
                    studentsRecords.Add(name, new List<decimal>() { grade });
                }
            }

            foreach (var item in studentsRecords)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.Write($"(avg: {item.Value.Average():f2})");
                Console.WriteLine();
            }
        }
    }
}
