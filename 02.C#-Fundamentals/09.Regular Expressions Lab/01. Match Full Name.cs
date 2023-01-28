namespace TextProcessing
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        static void Main()
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);


            Console.WriteLine(string.Join(" ", matches));
        }
    }
}