using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T088
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread0 = new Thread(Printer.Print);
            thread0.Start();

            Thread thread = new Thread(new ThreadStart(Printer.Print));
            thread.Start();

            Thread thread1 = new Thread(delegate() { Printer.Print(); });
            thread1.Start();

            Thread thread2 = new Thread(() => Printer.Print());
            thread2.Start();

            Printer printer = new Printer();
            Thread thread3 = new Thread(() => printer.NStPrint());
            thread3.Start();

            while (thread3.IsAlive)
            {
                Thread.Sleep(5000);
            }
        }
    }

    public class Printer
    {
        public static void Print() {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void NStPrint()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
