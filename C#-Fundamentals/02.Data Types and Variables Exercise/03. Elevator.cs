namespace Program
{
    using System;

    public class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((double)people / elevatorCapacity);
            Console.WriteLine($"{courses:f0}");
        }
    }
}
