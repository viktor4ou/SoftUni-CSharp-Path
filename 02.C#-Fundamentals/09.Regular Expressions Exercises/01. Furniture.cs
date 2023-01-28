using System.Collections.Generic;

namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        static void Main()
        {
            string pattern = @">>(?<item>[A-Z]*[a-z]*)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";
            double sum = 0.0;
            List<string> items = new List<string>();

            string input;
            while ((input = Console.ReadLine())!= "Purchase")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = 
                 matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    string item = match.Groups["item"].Value;
                    double price = double.Parse(match.Groups["price"].Value);
                    double quantity = double.Parse(match.Groups["quantity"].Value);
                    items.Add(item);
                    sum += (price * quantity);
                }
            }

            Console.WriteLine("Bought furniture:");
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
            
        }
    }
}