using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CSharpBasics_T093
{
    internal class Program
    {
        public static int Sum = 0;
        public static object _lock = new object();

        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            // RunSum method will not give correct output as it's working on shared resource.
            Thread T1 = new Thread(RunSumWithInterlock);
            Thread T2 = new Thread(RunSumWithInterlock);
            Thread T3 = new Thread(RunSumWithInterlock);

            Thread T4 = new Thread(RunSumWithLock);
            Thread T5 = new Thread(RunSumWithLock);
            Thread T6 = new Thread(RunSumWithLock);

            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();

            stopwatch.Stop();
            Console.WriteLine("Sum Result: " + Sum);
            Console.WriteLine("Sum Result Time: " + stopwatch.ElapsedTicks);
            
            stopwatch = Stopwatch.StartNew();
            T4.Start();
            T5.Start();
            T6.Start();
            T4.Join();
            T5.Join();
            T6.Join();

            stopwatch.Stop();
            Console.WriteLine("Sum Result: " + Sum);
            Console.WriteLine("Sum Result Time: " + stopwatch.ElapsedTicks);
        }

        public static void RunSum(){
            for (int i = 0; i < 1000000; i++)
            {
                Sum += i;
            }
        }

        public static void RunSumWithInterlock(){
            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Increment(ref Sum);
            }
        }

        // Using Lock Method
        public static void RunSumWithLock(){
            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                {
                    Sum++;
                }
            }
        }
    }
}
