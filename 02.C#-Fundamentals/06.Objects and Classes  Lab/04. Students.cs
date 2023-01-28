namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            string cmd;
            while ((cmd = Console.ReadLine())!= "end")
            {
                string[] studentsArg = cmd.Split(" ").ToArray();

                string firstName = studentsArg[0];
                string lastName = studentsArg[1];
                int age = int.Parse(studentsArg[2]);
                string town = studentsArg[3];

                Student student = new Student(firstName, lastName, age, town);

                students.Add(student);

            }

            string comapereCity = Console.ReadLine();
            foreach (var student in students )
            {
                if (comapereCity == student.Town)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string  Town { get; set; }

        

        public Student(string firstName, string lastName, int age, string town)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Town = town;
        }
    }
}