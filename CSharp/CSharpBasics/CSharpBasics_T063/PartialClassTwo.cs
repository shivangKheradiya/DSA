using System;

namespace CSharpBasics_T063
{
    public sealed partial class PartialClass
    {
        public void Print()
        {
            Console.WriteLine("Hii");
            PrintNotImplimented();
        }
    }
}
