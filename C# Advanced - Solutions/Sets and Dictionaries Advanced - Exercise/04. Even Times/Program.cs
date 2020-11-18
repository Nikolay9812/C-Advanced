using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<int, int> myDict = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!myDict.ContainsKey(number))
                {
                    myDict[number] = 1;
                }
                else
                {
                    myDict[number]++;
                }
            }

            foreach (var item in myDict.Where(x => x.Value % 2 == 0))
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}
