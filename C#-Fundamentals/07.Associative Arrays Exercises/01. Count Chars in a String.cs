namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            string[] words = 
                Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                for (int j = 0; j < word.Length; j++)
                {
                    if (charCount.ContainsKey(word[j]))
                    {
                        charCount[word[j]]++;
                    }
                    else if (!charCount.ContainsKey(word[j]))
                    {
                        charCount.Add(word[j],1);
                    }
                }
            }

            foreach (var character in charCount)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}