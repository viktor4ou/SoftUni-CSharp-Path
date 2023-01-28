using System;
using System.Linq;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            Console.WriteLine(VowelsCount(word));
        }
        static int VowelsCount(string word)
        {
            int VowelsCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'A' || 
                    word[i] == 'e' || word[i] == 'E' || 
                    word[i] == 'i' || word[i] == 'I' || 
                    word[i] == 'o' || word[i] == 'O' || 
                    word[i] == 'u' || word[i] == 'U')
                {
                    VowelsCount++;
                }
            }

            return VowelsCount;
        }
       


    }
}