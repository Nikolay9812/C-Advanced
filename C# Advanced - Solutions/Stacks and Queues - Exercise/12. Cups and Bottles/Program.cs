using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int wastedWater = 0;

            while (true)
            {
                int currBottle = bottles.Pop();

                if (currBottle < cups.Peek())
                {
                    int currCup = cups.Dequeue();
                    currCup -= currBottle;
                    while (true)
                    {
                        int nowBottle = bottles.Pop();

                        if (nowBottle < currCup)
                        {
                            currCup -= nowBottle;
                        }
                        else
                        {
                            wastedWater += nowBottle - currCup;
                            break;
                        }

                        if (bottles.Count == 0)
                        {
                            Console.WriteLine($"Cups: {currCup + " " + string.Join(" ", cups)}");
                            Console.WriteLine("Wasted litters of water: " + wastedWater);
                            return;
                        }
                    }
                }
                else if (currBottle >= cups.Peek())
                {
                    wastedWater += currBottle - cups.Peek();
                    cups.Dequeue();
                }

                if (cups.Count == 0)
                {
                    Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    return;
                }
                else if (bottles.Count == 0)
                {
                    Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                    Console.WriteLine("Wasted litters of water: " + wastedWater);
                    return;
                }
            }
        }
    }
}