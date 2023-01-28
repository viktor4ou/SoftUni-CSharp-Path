namespace Regex
{
    using System;
    using System.Text.RegularExpressions;
    public class Program
    {
        static void Main()
        {
            string pattern = "^[^\\%\\|\\$\\.]*?\\%(?<customer>[A-Z][a-z]+)\\%[^\\%\\|\\$\\.]*?<(?<product>\\w+)>[^\\%\\|\\$\\.]*?\\|(?<quantity>\\d+)\\|[^\\%\\|\\$\\.]*?(?<price>\\d+(\\.\\d+)?)\\$[^\\%\\|\\$\\.]*?$";
            double totalPrice = 0;

            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Regex regex = new Regex(pattern);
                MatchCollection matches = regex.Matches(input);
                string customerName;
                string productName;
                int quantity;
                double price;

                foreach (Match match in matches)
                {
                    customerName = match.Groups["customer"].Value;
                    productName = match.Groups["product"].Value;
                    quantity = int.Parse(match.Groups["quantity"].Value);
                    price = double.Parse(match.Groups["price"].Value);
                    double currPrice = price * quantity;

                    Console.WriteLine($"{customerName}: {productName} - {currPrice:f2}");
                    totalPrice += currPrice;
                }
            }
            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}