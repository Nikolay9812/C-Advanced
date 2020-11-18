using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> records = new HashSet<string>();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] element = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (element[0] == "IN")
                {
                    string carNumber = element[1];
                    records.Add(carNumber);
                }
                else if (element[0] == "OUT")
                {
                    string carNumber = element[1];

                    if (records.Contains(carNumber))
                    {
                        records.Remove(carNumber);
                    }
                }
            }

            if (records.Count != 0)
            {
                foreach (var item in records)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
