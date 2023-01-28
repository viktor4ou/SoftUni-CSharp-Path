namespace TextProcessing
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    public class Program
    {
        static void Main()
        {
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);


            Console.WriteLine(string.Join(", ", matches));
        }
    }
}