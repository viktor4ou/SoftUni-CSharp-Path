using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(word , n));
        }
        static string RepeatedString(string word , int n)
        {
            string repeatedString = string.Empty;
            for (int i = 0; i < n; i++)
            {
                repeatedString += word;
            }
            return repeatedString;
        }
       

    }
}
