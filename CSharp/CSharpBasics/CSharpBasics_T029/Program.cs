using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(); // Will be destroyed once the scope is over
            StudentCls studentCls = new StudentCls(); // Will remain in the memory untill GC Run
            student.Id = 5;
            studentCls.Id = 6;
            student.Name = "S";
            studentCls.Name = "S CLS";

            int i = 10; // Will be destroyed once the scope is over

            if (i == 10) 
            {
                int j = 1; // Will be destroyed once the scope is over
                Student newStudent = student; // Will be destroyed once the scope is over
                newStudent.Id = 7;
                StudentCls newStudentCls = studentCls; // Will remain in the memory untill GC Run
                newStudentCls.Id = 8;

                Console.WriteLine(student.Id); 
                Console.WriteLine(studentCls.Id); // Original value is modified as the class is reference type

                studentCls.Id = 9;
                Console.WriteLine(newStudentCls.Id); // value in copied variable is modified as the class is reference type
            } // j,newStudent will be destroyed

        } // i, student will be destroyed
    }

    public struct Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // ~Student() { } is not possible

        public Student(int id,string name) // It must have parameters, Parameter less is not possible
        {
            Id = id;
            Name = name;
        }
    }

    public sealed class StudentCls // Sealed class can't Inherrite
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public StudentCls() { } // It's not possible in case of structures, so it must have parameters in the structures

        ~StudentCls() { } // It's not possible in case of structures
    }

    // public class ExStudent : StudentCls { } Sealed class can't Inherrite
    // public struct ExStudent : Student { } Inherritance is not possible for struct
}
