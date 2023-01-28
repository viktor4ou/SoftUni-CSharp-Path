namespace TextProcessing
{
    using System;   
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string ban in bannedWords)
            {
                if (text.Contains(ban))
                {
                    text = text.Replace(ban, new string('*', ban.Length));
                }
            }

            Console.WriteLine(string.Join(' ',text));
        }
    }
}
