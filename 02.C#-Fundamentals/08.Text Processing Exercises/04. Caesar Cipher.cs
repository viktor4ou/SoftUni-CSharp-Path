namespace TextProcessing
{
    using System;
    using System.Text;
    public class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();

            string text = Console.ReadLine();

            foreach (char currChar in text)
            {
                int newChar = currChar + 3;
                char wordInString = (char) newChar;
                sb.Append(wordInString);
            }

            Console.WriteLine(sb);
        }
    }
}