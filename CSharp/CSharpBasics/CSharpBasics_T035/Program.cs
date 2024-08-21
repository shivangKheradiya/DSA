using System;

namespace CSharpBasics_T035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();
            
            // Class C is inharited from class A as well as Class B
            C c = new C();
            c.a = a;
            c.b = b;

            c.APrint();
            c.BPrint();
        }
    }

    public interface IA { void APrint(); }
    public interface IB { void BPrint(); }

    public interface IC : IA, IB { }

    class A : IA
    {
        public void APrint()
        {
            Console.WriteLine("Class A");
        }
    }

    class B : IB
    {
        public void BPrint()
        {
            Console.WriteLine("Class B");
        }
    }

    class C : IC
    {
        public A a { get; set; }
        public B b { get; set; }

        public void APrint()
        {
            a.APrint();
        }

        public void BPrint()
        {
            b.BPrint();
        }
    }
}
