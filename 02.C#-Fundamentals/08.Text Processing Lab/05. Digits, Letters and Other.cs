using System.Globalization;

namespace TextProcessing
{
    using System;
    using System.Linq;
    using System.Text;
    public class Program
    {
        static void Main()
        {   
            char[] word = Console.ReadLine().ToCharArray();

            char[] digits = word.Where(x => char.IsDigit(x)).ToArray();
            char[] letters = word.Where(x => char.IsLetter(x)).ToArray();
            char[] symbols = word.Where(x => !char.IsLetterOrDigit(x)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);

        }
    }
}
