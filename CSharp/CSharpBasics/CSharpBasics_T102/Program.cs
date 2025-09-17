using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T102
{
    internal class Program
    {
        public int counts { get; set; } = 0;

        static void Main(string[] args)
        {
            Thread T1 = new Thread( ()=> {
                counts = CountChar();
                // Method 1
                // Action action = () => Console.WriteLine(counts + " no of chars.");
                Action action = new Action(ConsoleWrite);
                this.BeginInvoke(action);
            });
            T1.Start();
            int chrs = counts;
            Console.WriteLine("Char count :" + chrs );

            Thread.Sleep(10000);
        }

        private void ConsoleWrite(){
            Console.WriteLine(counts + " no of chars.");
        }

        public int CountChar(){
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
