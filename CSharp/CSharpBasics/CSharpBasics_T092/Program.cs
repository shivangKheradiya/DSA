using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T092
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started");

            Thread t1 = new Thread(T1F);
            t1.Start();
            Thread t2 = new Thread(T2F);
            t2.Start();

            // t1.Join(200); With timeout value
            Console.WriteLine("T1 Finished");
            // t2.Join(6000); With timeout value
            Console.WriteLine("T2 Finished");

            Console.WriteLine("Finished");
        }

        public static void T1F()
        {
            Console.WriteLine("T1F");
            Thread.Sleep(5000);
        }

        public static void T2F()
        {
            Console.WriteLine("T2F");
            Thread.Sleep(6000);
        }
    }
}
