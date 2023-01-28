namespace TextProcessing
{
    using System;   
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string key = Console.ReadLine();
            string text = Console.ReadLine();

            while (text.Contains(key))
            {
                text = text.Remove(text.IndexOf(key),key.Length);
            }
            Console.WriteLine(text);
        }
    }
}
