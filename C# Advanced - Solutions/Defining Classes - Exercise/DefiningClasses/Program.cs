using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family members = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] element = Console.ReadLine().Split().ToArray();
                string name = element[0];
                int age = int.Parse(element[1]);
                Person data = new Person(name, age);
                members.AddMember(data);
            }

            Person[] membersAbove30 = members.GetMembersMoreThan30();

            foreach (var member in membersAbove30)
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }

        }
    }
}
