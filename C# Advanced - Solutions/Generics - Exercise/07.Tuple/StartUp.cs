using _07.Tuple;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] personInfo = Console.ReadLine().Split();
            string fullName = personInfo[0] + " " + personInfo[1];
            string town = personInfo[2];

            string[] beerInfo = Console.ReadLine().Split();
            string name = beerInfo[0];
            int liters = int.Parse(beerInfo[1]);

            string[] specialNumbers = Console.ReadLine().Split();
            int specialInt = int.Parse(specialNumbers[0]);
            double specialDouble = double.Parse(specialNumbers[1]);

            SpecialTuple<string, string> personTuple = new SpecialTuple<string, string>(fullName, town);
            SpecialTuple<string, int> beerTuple = new SpecialTuple<string, int>(name, liters);
            SpecialTuple<int, double> specialTuple = new SpecialTuple<int, double>(specialInt, specialDouble);

            Console.WriteLine(personTuple);
            Console.WriteLine(beerTuple);
            Console.WriteLine(specialTuple);
        }
    }
}

