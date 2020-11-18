using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, HashSet<string>>> records = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] element = input.Split();

                string vlogger = element[0];
                string command = element[1];

                if (command == "joined")
                {
                    if (!records.ContainsKey(vlogger))
                    {
                        records.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        records[vlogger].Add("followers", new HashSet<string>());
                        records[vlogger].Add("following", new HashSet<string>());

                    }

                }
                else if (command == "followed")
                {
                    string member = element[2];

                    if (vlogger != member && records.ContainsKey(vlogger) && records.ContainsKey(member))
                    {
                        records[vlogger]["following"].Add(member);
                        records[member]["followers"].Add(vlogger);
                    }

                }
            }


            Console.WriteLine($"The V-Logger has a total of {records.Count} vloggers in its logs.");

            int count = 1;

            foreach (var vlogger in records.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers, {vlogger.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (var follower in vlogger.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                count++;
            }
        }
    }
}
