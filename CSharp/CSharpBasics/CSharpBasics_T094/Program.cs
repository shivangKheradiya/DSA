using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T094
{
    internal class Program
    {
        public static int Sum = 0;
        static void Main(string[] args)
        {
            Thread T1 = new Thread(RunSumWithLock);
            Thread T2 = new Thread(RunSumWithLock);
            Thread T3 = new Thread(RunSumWithLock);
            
            T1.Start();
            T2.Start();
            T3.Start();
            T1.Join();
            T2.Join();
            T3.Join();
        }

        public static object _lock = new object();
        // Using Monitor Lock Method and only Lock Method are same
        public static void RunSumWithLock(){
            for (int i = 0; i < 1000000; i++)
            {
                Monitor.Enter(_lock);
                try
                {
                    Sum++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception occured.");
                }
                finally
                {
                    Monitor.Exit(_lock);
                }
            }
        }

        // Same method in c# 4 implimentation
        public static void RunSumWithLockAlternative(){
            for (int i = 0; i < 1000000; i++)
            {
                bool lockTaken = false;
                Monitor.Enter(_lock, ref lockTaken);
                try
                {
                    Sum++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Exception occured.");
                }
                finally
                {
                    if (lockTaken)
                    {
                        Monitor.Exit(_lock);
                    }
                }
            }
        }
    }
}
