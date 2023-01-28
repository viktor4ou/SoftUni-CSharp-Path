namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();

            Dictionary<string, int> Occurrences = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string wordInLowerCase = word.ToLower();
                if (Occurrences.ContainsKey(wordInLowerCase))
                {
                    Occurrences[wordInLowerCase]++;
                }
                else
                {
                    Occurrences.Add(wordInLowerCase, 1);
                }

            }
            foreach (var item in Occurrences.Where(x=> x.Value % 2 != 0))
            {
                Console.Write($"{item.Key} ");
            }
        }
    }
    
}