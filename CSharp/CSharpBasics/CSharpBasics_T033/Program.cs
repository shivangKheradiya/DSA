using System;

namespace CSharpBasics_T033
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Shape
    {
        //It does not have implimetation but has access modifiers
        public abstract void AbsShapeName();

        public void ShapeName()
        {
            Console.WriteLine("Abstract Shape");
        }
    }

    public interface IShape
    {  
        //It does not have implimetation as well as access modifiers
        void ShapeName();
    }

    // class can be inharited from a class or/and interfaces 
    // interfaces can only be inharited from interfaces
}
