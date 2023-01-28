using System;

namespace T08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kegs = int.Parse(Console.ReadLine());
            double bigestKegVolume = int.MinValue;
            string biggestKeg = string.Empty; 

            for(int keg = 1; keg <= kegs ; keg++) { 
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height; 
                if (volume > bigestKegVolume) {
                    bigestKegVolume = volume;
                    biggestKeg = model;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}