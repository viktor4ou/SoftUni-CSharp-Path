namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        static void Main()
        {
            List<string> list = Console.ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .ToList();
            
                Random random = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int randomIndex = random.Next(0, list.Count);
                string temp = list[i];
                list[i] = list[randomIndex];
                list[randomIndex] = temp;
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}