using System;

namespace CSharpBasics_T031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyShapeClass myShapeClass = new MyShapeClass();

            myShapeClass.PrintShapeName();
            ((IShape)myShapeClass).PrintShapeName();
            ((IBox)myShapeClass).PrintShapeName();

            Console.WriteLine("----------------------------");

            MyShapeClassWithDefaultIshape myShapeClassWithDefaultIshape = new MyShapeClassWithDefaultIshape();

            myShapeClassWithDefaultIshape.PrintShapeName();
            ((IShape)myShapeClassWithDefaultIshape).PrintShapeName();
            ((IBox)myShapeClassWithDefaultIshape).PrintShapeName();
        }
    }

    class MyShapeClass : IShape, IBox
    {
        void IShape.PrintShapeName()
        {
            Console.WriteLine("Inharited From IShape Called");
        }
        void IBox.PrintShapeName()
        {
            Console.WriteLine("Inharited From IBox Called");
        }

        public void PrintShapeName()
        {
            Console.WriteLine("Common Method Called");
        }
    }

    class MyShapeClassWithDefaultIshape : IShape, IBox
    {
        void IBox.PrintShapeName()
        {
            Console.WriteLine("Inharited From IBox Called");
        }

        public void PrintShapeName()
        {
            Console.WriteLine("Common Method Called");
        }
    }

    interface IShape
    {
        void PrintShapeName();
    }

    interface IBox
    {
        void PrintShapeName();
    }
}
