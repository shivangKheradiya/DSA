using System;
using System.Collections.Generic;

namespace CSharpBasics_T037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Name = "StudentA", TotalMarks = 500f, ObtainedMarks = 400f, TotalSubjects = 5 });
            students.Add(new Student() { Name = "StudentB", TotalMarks = 600f, ObtainedMarks = 300f, TotalSubjects = 6 });
            students.Add(new Student() { Name = "StudentC", TotalMarks = 400f, ObtainedMarks = 200f, TotalSubjects = 4 });

            Student.StudentsHasCapacity(students, 3);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public float TotalMarks { get; set; }
        public float ObtainedMarks { get; set; }
        public int TotalSubjects { get; set; }

        public static void StudentsHasCapacity(List<Student> students, int N)
        {
            foreach (Student student in students)
            {
                if (student.TotalSubjects > N)
                {
                    Console.WriteLine( student.Name + " has Good Capacity for " + N + " Subjects.");
                }
            }
        }
    }
}
