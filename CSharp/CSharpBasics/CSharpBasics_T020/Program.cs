using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10);
            Rectangle rectangle2 = new Rectangle();
            Console.WriteLine($"DefaultSideLength : {Rectangle.DefaultSideLength}");
            Console.WriteLine($"rectangle Variable SideLength : {rectangle.SideLength}");
            Console.WriteLine($"rectangle Paremeter : {Rectangle.Paremeter(rectangle)}");
            // Static members can't be called by the instance of the classes e.g. below code will give error
            // Console.WriteLine($"Updated DefaultSideLength : {rectangle.DefaultSideLength}");

            // Below code will update the property across all the instances of the classes as well even if the class is created
            Rectangle.DefaultSideLength = 50;
            Console.WriteLine($"Updated DefaultSideLength : {Rectangle.DefaultSideLength}");
        }
    }
}
