using System;

namespace CSharpBasics_T062
{
    public sealed partial class PartialClass : IMyClassA
    {
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("ID: " + this.ID + "; Name: " + this.Name);
        }

        public void PrintA()
        {
            
        }
    }

    public interface IMyClassA {
        void PrintA();
    }
    public interface IMyClassB {
        void PrintB();
    }
}
