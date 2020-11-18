using System;
using System.IO;

namespace _06._Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../../TestFolder");

            double totalSize = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                totalSize += fileInfo.Length;
            }

            using (StreamWriter writer = new StreamWriter("../../../Output.txt"))
            {
                writer.Write(totalSize.ToString());
            }


        }
    }
}
