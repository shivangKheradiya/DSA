using System;

namespace CSharpBasics_T022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathsExam mathsExam1 = new MathsExam();
            mathsExam1.ExamMarks = 25;
            mathsExam1.Result = 20;
            mathsExam1.SubjectInstructor = "SKM";
            mathsExam1.PrintInfo();

            EnglishExam englishExam = new EnglishExam();
            englishExam.ExamMarks = 50;
            englishExam.Result = 40;
            englishExam.PrintInfo();

            MathsExam mathsExam2 = new MathsExam();
            mathsExam2.ExamMarks = 25;
            mathsExam2.Result = 20;
            mathsExam2.SubjectInstructor = "SKM";
            Exam mathsExam3 = mathsExam2;
            mathsExam3.PrintInfo();

            Exam englishExam2 = new EnglishExam();
            englishExam2.ExamMarks = 50;
            englishExam2.Result = 40;
            englishExam2.PrintInfo();
        }
    }

    public class Exam
    {
        public string Subject;
        public int Result;
        public int ExamMarks;

        public Exam() { }

        public Exam(string subject)
        {
            Subject = subject;
        }

        public void PrintInfo()
        {
            Console.WriteLine($" {Subject} :: TotalMarks : {ExamMarks}, Result : {Result}");
        }
    }

    public class MathsExam : Exam
    {
        public string SubjectInstructor;
        public MathsExam()
        {
            Subject = "Maths";
        }

        // Inheritance methods can be hide
        // It will work without new keyword as well
        public new void PrintInfo()
        {
            // Below line is calling the method which is writen in base class
            base.PrintInfo();
            Console.WriteLine($" {Subject} :: TotalMarks : {ExamMarks}, Result : {Result} by {SubjectInstructor}");
        }
    }

    // Inheritance From Exam
    public class EnglishExam : Exam
    {
        public EnglishExam() : base("English") { }
    }
}
