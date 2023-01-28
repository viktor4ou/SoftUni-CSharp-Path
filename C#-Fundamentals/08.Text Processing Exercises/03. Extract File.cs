namespace TextProcessing
{
    using System;
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string[] fileDirectory = Console.ReadLine().Split("\\");
            string[] file = fileDirectory[fileDirectory.Length - 1].Split(".");
            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}