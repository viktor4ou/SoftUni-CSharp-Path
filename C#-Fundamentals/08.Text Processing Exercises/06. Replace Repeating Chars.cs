namespace TextProcessing
{
    using System;
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < word.Length - 1; i++)
            {
                if (word[i] == word[i+1])
                {
                    continue;
                }
                else
                {
                    sb.Append(word[i]);
                }
            }

            sb.Append(word[word.Length - 1]);
            Console.WriteLine(sb);
        }
    }
}