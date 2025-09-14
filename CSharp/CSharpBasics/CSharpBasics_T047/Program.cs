using System;

namespace CSharpBasics_T047
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string type in Enum.GetNames( typeof(Gender))) {
                Console.WriteLine(type);
            }

            // Strongly typed constant
            foreach (short val in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine(val);
            }

            // Strongly typed constant, Implicite type cast is not possible. So, we must cast it.
            // Gender gender = 2;  //will not work
            // Gender gender = Season.Winter; //will not work
            Gender gender = (Gender)2;
        }
        public enum Gender:short
        {
            Unknown = 0,
            Male = 1,
            Female = 2
            // Female = 2546522365 will give error as it's extended from short
        }
    }

}
