namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int numberCopy = 0;
            bool toe = false;
            for (int i = 1; i <= n; i++)
            {
                numberCopy = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i /= 10;
                }
                toe = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", numberCopy, toe);
                sum = 0;
                i = numberCopy;
                // sum e sum
                //if-vete
            }

        }
    }
}