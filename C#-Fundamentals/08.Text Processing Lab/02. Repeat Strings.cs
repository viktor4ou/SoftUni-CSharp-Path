namespace TextProcessing
{
    using System;   
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string[] strings = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = 0; j < strings[i].Length; j++)
                {
                    Console.Write(strings[i]);
                }
            }
        }
    }
}
