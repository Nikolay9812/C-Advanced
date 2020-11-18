using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            People = new List<Person>();
        }

        public List<Person> People { get; set; }

        public void AddMember(Person member)
        {
            People.Add(member);
        }

        public Person GetOldestMember()
        {
            int maxAge = int.MinValue;
            Person curPerson = null;

            foreach (var person in People)
            {
                int curAge = person.Age;

                if (curAge > maxAge)
                {
                    maxAge = curAge;
                    curPerson = person;
                }
            }
            return curPerson;
        }

        public Person[] GetMembersMoreThan30()
        {
            Person[] member = People.Where(x => x.Age > 30).OrderBy(x => x.Name).ToArray();
            return member;
        }
    }
}
