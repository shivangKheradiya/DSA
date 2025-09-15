using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T061
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PartialClass partialClass = new PartialClass();
            partialClass.ID = 1;
            partialClass.Name = "abc";
            partialClass.Print();
        }
    }
}
