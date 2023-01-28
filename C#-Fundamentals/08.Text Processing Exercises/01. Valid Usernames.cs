namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            string[] passwords = Console.ReadLine().Split(", ");
            for (int i = 0; i < passwords.Length; i++)
            {
                
                if (ValidLength(passwords, i) && ContainsHyphensOrUnderscore(passwords,i))
                {
                    Console.WriteLine(passwords[i]);
                }
                
            }
        }

        static bool ValidLength(string[] passwords, int i)
        {
            if (passwords[i].Length >= 3 && passwords[i].Length <= 16)
            {
                return true;
            }
            return false;
        }
        static bool ContainsHyphensOrUnderscore(string[] passwords, int i)
        {
            string word = passwords[i];
            for (int k = 0; k < word.Length; k++)
            {
                if (char.IsLetter(word[k]) == false && char.IsDigit(word[k]) == false && word[k] != '_' && word[k] != '-')
                {
                    return false;
                }
            }
            return true;
        }

    }

}