
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {     
               while (true)
                {
                    Console.WriteLine("Choose an operation: ");
                    Console.WriteLine("1. Create File");
                    Console.WriteLine("2. Read File");
                    Console.WriteLine("3. Append to File");
                    Console.WriteLine("4. Delete File");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice (1-5): ");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.Write("Enter file name: ");
                        string createFileName = Console.ReadLine();
                        Console.Write("Enter content: ");
                        string createFileContent = Console.ReadLine();
                        CreateFile(createFileName, createFileContent);
                    }
                    else if (choice == "2")
                    {
                        Console.Write("Enter file name to read: ");
                        string readFile = Console.ReadLine();
                        ReadFile(readFile);
                    }
                    else if (choice == "3")
                    {
                        Console.Write("Enter file name to append: ");
                        string appendFileName = Console.ReadLine();
                        Console.Write("Enter content to append: ");
                        string appendContent = Console.ReadLine();
                        AppendToFile(appendFileName, appendContent);
                    }
                    else if (choice == "4")
                    {
                        Console.Write("Enter file name to delete: ");
                        string deleteFileName = Console.ReadLine();
                        DeleteFile(deleteFileName);
                    }
                    else if (choice == "5")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    }
                }
            }

            static void CreateFile(string fileName, string content)
            {
                string path = Path.Combine("c:\\simplilearn\\Day-7", fileName);

                try
                {
                    File.WriteAllText(path, content);
                    Console.WriteLine($"File '{fileName}' created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating file: {ex.Message}");
                }
            }

            static void ReadFile(string fileName)
            {
                string path = Path.Combine("c:\\simplilearn\\Day-7", fileName);

                try
                {
                    string content = File.ReadAllText(path);
                    Console.WriteLine($"Content of '{fileName}':");
                    Console.WriteLine(content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error reading file: {ex.Message}");
                }
            }

            static void AppendToFile(string fileName, string content)
            {
                string path = Path.Combine("c:\\simplilearn\\Day-7", fileName);

                try
                {
                    File.AppendAllText(path, content);
                    Console.WriteLine($"Content appended to '{fileName}' successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error appending to file: {ex.Message}");
                }
            }

            static void DeleteFile(string fileName)
            {
                string path = Path.Combine("c:\\simplilearn\\Day-7", fileName);

                try
                {
                    File.Delete(path);
                    Console.WriteLine($"File '{fileName}' deleted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error deleting file: {ex.Message}");
                }  
            }
        }

    }


    
