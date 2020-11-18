using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int message = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(message);
                Console.WriteLine(box);
            }
        }
    }
}
