using System;

namespace _03.Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            string fullFileName = filePath.Substring(filePath.LastIndexOf("\\") + 1);
            string fileExtension = fullFileName.Substring(fullFileName.IndexOf(".") + 1);
            string fileName = fullFileName.Remove(fullFileName.IndexOf("."));

            Console.WriteLine("File name: " + fileName);
            Console.WriteLine("File extension: " + fileExtension);
        }
    }
}
