using System;
using System.IO;

namespace _04._Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader firstReader = new StreamReader("../../../FileOne.txt");
            using StreamReader secondReader = new StreamReader("../../../FileTwo.txt");
            using StreamWriter outputWriter = new StreamWriter("../../../Output.txt");

            while (true)
            {
                string firstInput = firstReader.ReadLine();
                string secondInput = secondReader.ReadLine();

                if (firstInput == null && secondInput == null)
                {
                    break;
                }

                if (firstInput != null)
                {
                    outputWriter.WriteLine(firstInput);
                }

                if (secondInput != null)
                {
                    outputWriter.WriteLine(secondInput);
                }
            }
        }
    }
}
