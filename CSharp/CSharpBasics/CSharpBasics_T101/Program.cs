using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrs = CountChar();
            Console.WriteLine("Char count :" + chrs );
            asyncTaskRun();
            Thread.Sleep(10000);
        }

        public static async void asyncTaskRun(){
            Task<int> myTask = new Task<int>(CountChar);
            myTask.Start();
            int chrs = await myTask;
            Console.WriteLine("Char count :" + chrs );
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
