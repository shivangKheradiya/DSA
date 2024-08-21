using System;
using System.Collections.Generic;

namespace CSharpBasics_T038
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { Name = "StudentA", TotalMarks = 500f, ObtainedMarks = 400f, TotalSubjects = 5 });
            students.Add(new Student() { Name = "StudentB", TotalMarks = 600f, ObtainedMarks = 300f, TotalSubjects = 6 });
            students.Add(new Student() { Name = "StudentC", TotalMarks = 400f, ObtainedMarks = 200f, TotalSubjects = 4 });

            GoodCapacity goodCapacityobj = new GoodCapacity(Program.goodCapacity);
            Student.StudentsHasCapacity(students, goodCapacityobj);

            // It's possible to pass direct method name as like below
            Student.StudentsHasCapacity(students, goodCapacity);

            // It's also possible to use labda expressions
            Student.StudentsHasCapacity(students, student => student.TotalSubjects > 5);
        }

        private static bool goodCapacity(Student student)
        {
            return (student.TotalSubjects > 5) ? true : false ;
        }
    }

    public delegate bool GoodCapacity(Student student);

    public class Student
    {
        public string Name { get; set; }
        public float TotalMarks { get; set; }
        public float ObtainedMarks { get; set; }
        public int TotalSubjects { get; set; }

        public static void StudentsHasCapacity(List<Student> students, GoodCapacity goodCapacity)
        {
            foreach (Student student in students)
            {
                if (goodCapacity(student))
                {
                    Console.WriteLine(student.Name + " has Good Capacity for given Subjects.");
                }
            }
        }
    }
}
