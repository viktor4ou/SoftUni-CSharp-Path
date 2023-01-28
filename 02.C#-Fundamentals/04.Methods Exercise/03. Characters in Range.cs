using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace _1st_october
{
    public class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            int firstCharInASCII = (int)firstChar;
            int secondCharInASCII = (int)secondChar;
            CharIntoInt(firstCharInASCII, secondCharInASCII);
        }

        private static void CharIntoInt(int firstCharInASCII, int secondCharInASCII)
        {
            if (firstCharInASCII > secondCharInASCII)
            {
                for (int i = secondCharInASCII + 1; i < firstCharInASCII; i++)
                {
                    CharPrinterInASCII(i);
                }
            }
            else
            {
                for (int i = firstCharInASCII + 1; i < secondCharInASCII; i++)
                {
                    CharPrinterInASCII(i);
                }
            }
        }

        static void CharPrinterInASCII(int i)
        {
            Console.Write((char)i + " ");
        }
    }
}