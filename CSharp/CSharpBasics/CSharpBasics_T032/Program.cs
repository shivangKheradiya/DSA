using System;

namespace CSharpBasics_T032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            Console.WriteLine(box.ShapeName());

            Shape shape = box;
            Console.WriteLine(shape.ShapeName());
        }
    }

    public abstract class Shape
    {
        public abstract string ShapeName();

        public void ImplimentationPossible()
        {
            Console.WriteLine("Implimentation is Possible");
        }
    }

    // Abstract Class can be inharritated from abstract classes
    // Abstract Class can't be sealed e.g. public abstract sealed class AbsBox 
    public abstract class AbsBox : Shape
    {
        // It may contant abstract methods, properties, indexers and events but not mandatory
    }

    public class Box : Shape
    {
        // All memebers from abstract must be defined here
        public override string ShapeName()
        {
            return "Box";
        }
    }
}
