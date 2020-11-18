using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> party = new HashSet<string>();

            while (true)
            {
                string guest = Console.ReadLine();

                if (guest.Length == 8)
                {
                    party.Add(guest);
                }

                if (guest == "PARTY")
                {
                    while (true)
                    {
                        string reservatedGuest = Console.ReadLine();

                        if (party.Contains(reservatedGuest))
                        {
                            party.Remove(reservatedGuest);
                        }

                        if (reservatedGuest == "END")
                        {
                            break;
                        }
                    }
                    break;
                }
            }

            Console.WriteLine(party.Count);

            foreach (var guest in party.OrderByDescending(x => char.IsDigit(x[0])))
            {
                Console.WriteLine(guest);
            }
        }
    }
}
