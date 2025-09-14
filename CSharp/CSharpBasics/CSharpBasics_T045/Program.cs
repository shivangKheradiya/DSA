using System;

namespace CSharpBasics_T045
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
        public int Gender { get; set; }

        public string GetGender()
        {
            switch (Gender)
            {
                case 1:
                    return "Male";
                case 2:
                    return "Female";
                default:
                    return "Unknown";
            }
        }
    }
}
