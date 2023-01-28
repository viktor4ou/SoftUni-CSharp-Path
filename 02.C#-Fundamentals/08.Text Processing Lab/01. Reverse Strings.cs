namespace TextProcessing
{
    using System;   
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string word = input;
                StringBuilder sb = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }

                Console.WriteLine($"{word} = {sb}");
            }
        }
    }
}
