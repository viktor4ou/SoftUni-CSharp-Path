namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            // phrases.lenght = 6;
            string[] phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };
            // events.lenght = 6
            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            // authros.lenght = 8;
            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            // cities.lenght = 5;
            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            Random random = new Random();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int randomNumberForCities = random.Next(0, cities.Length);
                int randomNumberForEvents = random.Next(0, events.Length);
                int randomNumbersForAuthors = random.Next(0 , authors.Length);
                int randsomNumbersForPhases = random.Next(0, phrases.Length);
                Console.WriteLine($"{phrases[randsomNumbersForPhases]} {events[randomNumberForEvents]} {authors[randomNumbersForAuthors] } – {cities[randomNumberForCities]}.");
            }
        }
    }
}