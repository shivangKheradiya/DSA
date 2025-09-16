using System;
using System.Collections.Generic;

namespace CSharpBasics_T082
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQ = new Queue<int>();
            intQ.Enqueue(19);
            intQ.Enqueue(5);
            intQ.Enqueue(20);
            intQ.Enqueue(10);

            // Remove the object Begineer member of queue
            int removedObj = intQ.Dequeue();

            // Without Remove the object Begineer member of queue
            int peekObj = intQ.Peek();
        }
    }
}
