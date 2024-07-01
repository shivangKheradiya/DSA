using System;

namespace CSharpBasics_T024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exam exam = new Exam();
            Exam Tempexam;
            MathsExam mathsExam = new MathsExam();
            EnglishExam englishExam = new EnglishExam();

            exam.PrintInfo();

            // Method Hiding
            mathsExam.PrintInfo();
            // Method Hiding
            englishExam.PrintInfo();

            exam.PrintVirtualInfo();

            // Method Hiding
            mathsExam.PrintVirtualInfo();
            // Method Hiding
            englishExam.PrintVirtualInfo();

            Tempexam = mathsExam;
            Tempexam.PrintInfo();
            // Polymorphysm or overriding
            Tempexam.PrintVirtualInfo();
        }
    }
    public class Exam
    {
        public void PrintInfo()
        {
            Console.WriteLine($"This is Exam Class");
        }
        public virtual void PrintVirtualInfo()
        {
            Console.WriteLine($"This is Exam Class With Virtual Implimentation");
        }
    }

    public class MathsExam : Exam
    {
        public new void PrintInfo()
        {
            Console.WriteLine($"This is MathsExam Class");
        }
        public override void PrintVirtualInfo()
        {
            Console.WriteLine($"This is MathsExam Class With Virtual Implimentation");
        }
    }

    public class EnglishExam : Exam
    {
        public new void PrintInfo()
        {
            Console.WriteLine($"This is EnglishExam Class");
        }
        public override void PrintVirtualInfo()
        {
            Console.WriteLine($"This is EnglishExam Class With Virtual Implimentation");
        }
    }
}
