using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T083
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> intS = new Stack<int>();
            intS.Push(19);
            intS.Push(5);
            intS.Push(20);
            intS.Push(10);

            // Remove the object Ending member of Stack
            int removedObj = intS.Pop();

            // Without Remove the object Ending member of Stack
            int peekObj = intS.Peek();

            bool hasObj = intS.Contains(10);
        }
    }
}
