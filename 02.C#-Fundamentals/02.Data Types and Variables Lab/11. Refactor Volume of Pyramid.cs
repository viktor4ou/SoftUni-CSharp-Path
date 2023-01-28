namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            double length = 0.0;
            double width = 0.0;
            double heigth = 0.0;
            double pyramidVolume = 0.0;
            
            Console.Write("Length: ");
            Length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            Width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            Heigth = double.Parse(Console.ReadLine());

            pyramidVolume = (Length  * Width * Heigth) / 3.0;
            Console.Write($"Pyramid Volume: {pyramidVolume:f2}");


        }
    }
}