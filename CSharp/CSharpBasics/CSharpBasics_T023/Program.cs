using System;

namespace CSharpBasics_T023
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
            // Virtual & Override are extensively used for following case 
            Exam mathsExam3 = mathsExam2;
            mathsExam3.PrintInfo();
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

        public virtual void PrintInfo() 
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

        public override void PrintInfo()
        {
            Console.WriteLine($" {Subject} :: TotalMarks : {ExamMarks}, Result : {Result} by {SubjectInstructor}");
        }
    }

    public class EnglishExam : Exam
    {
        public EnglishExam() : base("English") { }

        public override void PrintInfo()
        {
            base.PrintInfo();
        }
    }
}
