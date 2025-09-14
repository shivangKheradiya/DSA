using System;

namespace CSharpBasics_T056
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic method
            Console.WriteLine(Calculator.AreEqual<string>("A", "B"));

            // Example for class generics
            Console.WriteLine(Calculator<int>.AreEqual(10, 10));
        }
    }

    public class Calculator
    {
        // Method 1
        public static bool AreEqual(int a, int b)
        {
            return a == b;
        }

        // Method 2
        public static bool AreEqual(object a, object b)
        {
            return a == b;
        }

        // Method 3 using Generics
        public static bool AreEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }

    public class Calculator<T>
    {
        // Method 3 using Generics on class
        public static bool AreEqual(T a, T b)
        {
            return a.Equals(b);
        }
    }
}
