using System;

namespace CSharpBasics_T021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // We can define 2 exams for both having different marks
            MathsExam mathsExam1 = new MathsExam();
            mathsExam1.ExamMarks = 25;
            mathsExam1.Result = 20;
            mathsExam1.SubjectInstructor = "SKM";
            Console.WriteLine($" {mathsExam1.Subject} :: TotalMarks : {mathsExam1.ExamMarks}, Result : {mathsExam1.Result} by {mathsExam1.SubjectInstructor}");

            EnglishExam englishExam = new EnglishExam();
            englishExam.ExamMarks = 50;
            englishExam.Result = 40;
            Console.WriteLine($" {englishExam.Subject} :: TotalMarks : {englishExam.ExamMarks}, Result : {englishExam.Result}");
        }
    }

    public class Exam
    {
        public string Subject;
        public int Result;
        public int ExamMarks;

        public Exam()
        {
            Console.WriteLine("Exam Class Constructor called");
        }

        public Exam(string subject)
        {
            Subject = subject;
            Console.WriteLine("Exam Class Constructor called with subject");
        }

    }

    // Inheritance From Exam Class
    // Class can have only one base class
    // Multilevel inheritance is possible for class
    public class MathsExam : Exam
    {
        public string SubjectInstructor;
        public MathsExam()
        {
            Subject = "Maths";
            Console.WriteLine("MathsExam Class Constructor called");
        }
    }

    // Inheritance From Exam
    public class EnglishExam : Exam 
    {
        public EnglishExam() : base("English")
        {
            Console.WriteLine("EnglishExam Class Constructor called");
        }
    }
}
