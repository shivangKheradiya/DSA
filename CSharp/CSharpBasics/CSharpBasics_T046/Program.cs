using System;

namespace CSharpBasics_T046
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Customer
    {
        public string name { get; set; }
        public Gender Gender { get; set; }
        public string GetGender()
        {
            switch (Gender)
            {
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Unknown";
            }
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
}
