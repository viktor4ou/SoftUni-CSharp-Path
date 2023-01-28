namespace Triples_of_Latin_Letters
{
    using System;
    public class Triples_of_Latin_Letters
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                char firstChar = (char)('a' + i);
                for (int j = 0; j < n; j++)
                {
                    char secondChar = (char)('a' + j);
                    for (int k = 0; k < n; k++)
                    {
                        char thirthChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirthChar}");
                    }
                }
            }
        }
    }
}