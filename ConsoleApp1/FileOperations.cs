using System;
using System.IO;

namespace ConsoleApp1
{
    internal class FileOperations
    {
        string filePath = "D:\\Work\\AspDotNet_Projects\\New folder\\myfile.txt";

        // ✅ Create a new file
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

        // ✅ Add (append) content to file
        internal void addContentOnFile()
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Welcome to file handling concepts.");
            }
            Console.WriteLine("Content added successfully.");
        }

        // ✅ Read all content
        internal void readFile()
        {
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("File Content:\n" + content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        // ✅ Read file line by line
        internal void readFileLineByLine()
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        // ✅ Copy file
        internal void copyFile(string destinationPath)
        {
            if (File.Exists(filePath))
            {
                File.Copy(filePath, destinationPath, true); // overwrite = true
                Console.WriteLine($"File copied to {destinationPath}");
            }
            else
            {
                Console.WriteLine("Source file not found.");
            }
        }

        // ✅ Move file
        internal void moveFile(string destinationPath)
        {
            if (File.Exists(filePath))
            {
                File.Move(filePath, destinationPath, true); // overwrite = true (from .NET 6+)
                Console.WriteLine($"File moved to {destinationPath}");
            }
            else
            {
                Console.WriteLine("Source file not found.");
            }
        }

        // ✅ Delete file
        internal void deleteFile()
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
