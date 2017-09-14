using System;
using System.IO;

namespace Ch03_HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before parsing");
            Console.Write("What is your age? ");
            string input = Console.ReadLine();
            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"You are {age} years old.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The age you entered is not a valid number format.");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            Console.WriteLine("After parsing");

            string path = @"C:\Users\mcharette\Documents\Coding\C#\C# Book\cs7dotnetcorepersonal\Chapter03\Chapter03";
            FileStream file = null;
            StreamWriter writer = null;
            try
            {
                if (Directory.Exists(path))
                {
                    file = File.OpenWrite(Path.Combine(path, "file.txt"));
                    writer = new StreamWriter(file);
                    writer.WriteLine("Hello, C#!");
                }
                else
                {
                    Console.WriteLine($"{path} does not exist!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            finally
            {
                if(writer != null)
                {
                    writer.Dispose();
                    Console.WriteLine("The writer's unmanaged resources have been disposed.");
                }
                if(file != null)
                {
                    file.Dispose();
                    Console.WriteLine("The file's unamanged resources have been disposed.");
                }
            }

            using (FileStream file2 = File.OpenWrite(Path.Combine(path, "file2.txt")))
            {
                using (StreamWriter writer2 = new StreamWriter(file2))
                {
                    try
                    {
                        writer2.WriteLine("Welcome, .NET Core!");
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine($"{ex.GetType()} says {ex.Message}");
                    }
                }
            }
        }
    }
}
