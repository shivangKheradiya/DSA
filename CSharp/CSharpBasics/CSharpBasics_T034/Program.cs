using System;

namespace CSharpBasics_T034
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // D d = new D();
        }
    }

    class A 
    {
        public virtual void Print()
        {
            Console.WriteLine("Class A");
        }
    }

    class B:A
    {
        public override void Print()
        {
            Console.WriteLine("Class B");
        }
    }

    class C : A
    {
        public override void Print()
        {
            Console.WriteLine("Class C");
        }
    }

    // This is not possible because of diamond problem
    // class D : B , C
    // {
    // }
}
