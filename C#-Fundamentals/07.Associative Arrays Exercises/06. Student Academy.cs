namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            Dictionary<string, double> studentsList = new Dictionary<string, double>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsList.ContainsKey(name))
                {
                    studentsList[name] = (studentsList[name] + grade) / 2;
                }
                else if (!studentsList.ContainsKey(name))
                {
                    studentsList.Add(name,grade);
                }
            }

            foreach (var student in studentsList.Where(x => x.Value >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value:f2}");
            }
        }
       
    }
}