using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T020
{
    public class Rectangle
    {
        // Static memebrs values are shared between all the instances or inheritance of the classes in memeory
        public static float ParemeterMultiplier;
        // Static memebrs values can be modified acrross all the objecs as well
        public static float DefaultSideLength { get; set; } = 5;

        public float SideLength { get; set; }

        static Rectangle() {
            // Static Constructor are called only once even if we create N number of instances
            Console.WriteLine("Static Construcor is called only once even if we have multiple instances.");
            ParemeterMultiplier = 4.0f;
        }

        public Rectangle() : this(DefaultSideLength) { }

        // Below code will not allow to compile pr built the solution
        // public static Rectangle(){ }

        public Rectangle(float sideLength) 
        {
            SideLength = sideLength;
        }

        public static float Paremeter( Rectangle rectangle )
        {
            float paremeter = rectangle.SideLength * ParemeterMultiplier;
            return paremeter;
        }
    }
}
