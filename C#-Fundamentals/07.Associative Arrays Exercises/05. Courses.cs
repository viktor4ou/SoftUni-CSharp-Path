namespace Dictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end") 
            {
                string[] cmdArgs = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string courseName = cmdArgs[0];
                string name = cmdArgs[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(name);
                }
                else if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(name);
                }

            }

            foreach (var course in courses)
            {
                List<string> membersList = course.Value;
                Console.WriteLine($"{course.Key}: {membersList.Count}");
                foreach (var person in course.Value)
                {
                    Console.WriteLine($"-- {person}");
                }
            }
        }
       
    }
}