using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T065
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3] + ": Before");

            cars[3] = "X";
            Console.WriteLine(cars[3] + ": After");
        }
    }
}
