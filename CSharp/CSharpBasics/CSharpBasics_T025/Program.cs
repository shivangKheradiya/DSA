using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" 4 + 5 = {MyMath.Sum(4,5)}");
            Console.WriteLine($" 5 + 5 + 7.4 = {MyMath.Sum(5,5, 7.4f)}");

            float p;
            MyMath.Sum(5, 7.4f, out p);
            Console.WriteLine($" 5 + 7.4 = {p}");
        }
    }

    public class MyMath
    {
        public MyMath() { }

        // Method
        public static int Sum(int x, int y) 
        {
            return x + y;
        }

        // Method Overloading
        public static float Sum(float x, float y, float z)
        {
            return x + y + z;
        }

        // Method Overloading
        // Overloading is not dependent on return type
        // Method Signature covers only the args and type of args
        // params keyword is not consideing as different method signature... e.g. param int[] is same as int[]
        public static void Sum(float x, float y, out float sum)
        {
            sum = x + y;
        }
    }
}
