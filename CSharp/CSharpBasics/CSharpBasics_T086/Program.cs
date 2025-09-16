using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T086
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(5000);
            Thread t1 = new Thread(Print);
            t1.Start();
            Console.WriteLine("Thread is started.");
            Console.WriteLine(t1.ThreadState.ToString());
            Thread.Sleep(5000);
            Console.WriteLine("Thread is finished.");
        }

        public static void Print()
        {
            Console.WriteLine("Printing Task is running.");
            Thread.Sleep(500);
        }
    }
}
