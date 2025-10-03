using System;
using System.IO;

namespace ConsoleApp1
{
    internal class FileOperations
    {
        string filePath = "D:\\Work\\AspDotNet_Projects\\New folder\\myfile.txt";

        internal void createFile()
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File already exists.");
            }
            else
            {
                File.Create(filePath).Close();
                Console.WriteLine("File created successfully.");
            }
        }

        internal void addContentOnFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath, true)) // true = append
            {
                sw.WriteLine("Welcome to file handling concepts.");
            }
            Console.WriteLine("Content added successfully.");
        }
    }
}
