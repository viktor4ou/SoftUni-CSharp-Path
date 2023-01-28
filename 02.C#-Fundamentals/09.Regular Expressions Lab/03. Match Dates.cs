namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        static void Main()
        {
            string pattern = @"(?<day>\d{2})(/|-|.)(?<month>[A-Z]{1}[a-z]{2})\1(?<year>\d{4})";
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}