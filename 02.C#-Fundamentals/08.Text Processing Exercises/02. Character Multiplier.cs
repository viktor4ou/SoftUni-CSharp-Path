namespace TextProcessing
{
    using System;
    using System.Text;
    public class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();

            string firstWord = words[0]; // 1
            string secondWord = words[1]; // 4 

            int biggerLength = Math.Min(firstWord.Length, secondWord.Length); // 1
            int sum = 0;

            for (int i = 0; i < biggerLength; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            if (firstWord.Length != secondWord.Length) ;
            {
                bool IsFirstWordBigger = true;

                if (firstWord.Length < secondWord.Length)
                {
                    IsFirstWordBigger = false;
                }

                if (IsFirstWordBigger)
                {
                    for (int i = biggerLength; i < firstWord.Length; i++)
                    {
                        sum += firstWord[i];
                    }
                }
                else if (!IsFirstWordBigger)
                {
                    for (int i = biggerLength; i < secondWord.Length; i++)
                    {
                        sum += secondWord[i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}