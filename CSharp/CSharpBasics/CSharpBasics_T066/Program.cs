using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T066
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();

            Console.WriteLine(cars[1] + ": 1 Before");
            Console.WriteLine(cars[5] + ": 5 Before");
            cars["A"] = "X";
            Console.WriteLine(cars[1] + ": 1 After");
            Console.WriteLine(cars[5] + ": 5 After");
        }
    }
}
