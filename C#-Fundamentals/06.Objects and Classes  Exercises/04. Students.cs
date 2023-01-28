namespace Program
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] studentsArgs = Console.ReadLine().Split().ToArray();
                string firstName = studentsArgs[0];
                string secondName = studentsArgs[1];
                double grade = double.Parse(studentsArgs[2]);
                Student student = new Student(firstName,secondName,grade);
                studentsList.Add(student);
            }

            foreach (var student in studentsList.OrderByDescending(x => x.Grades))
            {
                Console.WriteLine(student.ToString());   
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public double  Grades { get; set; }
        public Student(string firstName, string secondName, double grades)
        {
            FirstName = firstName;
            SecondName = secondName;
            Grades = grades;

        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.SecondName}: {this.Grades:f2}";
        }
    }
}