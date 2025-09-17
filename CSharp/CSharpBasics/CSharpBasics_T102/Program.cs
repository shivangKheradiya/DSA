using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T102
{
    internal class Program
    {
        public static int counts { get; set; } = 0;

        static void Main(string[] args)
        {
            Thread T1 = new Thread(()=> {
                counts = CountChar();
                // Method 1
                //Action action = () => Console.WriteLine(counts + " no of chars.");
                Action action = new Action(ConsoleWrite);
                action.BeginInvoke();
            });
            T1.Start();
            int chrs = counts;
            Console.WriteLine("Char count :" + chrs );

            Thread.Sleep(10000);
        }

        private static void ConsoleWrite(){
            Console.WriteLine(counts + " no of chars.");
        }

        public static int CountChar(){
            int count = 0;
            using (StreamReader reader = new StreamReader(@"C:\db\x.txt"))
            {
                string content = reader.ReadToEnd();
                count += content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
    }
}
