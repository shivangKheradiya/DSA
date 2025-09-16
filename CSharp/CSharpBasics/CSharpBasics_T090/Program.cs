using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T090
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Task ID Number :");
            int taskID;
            if (int.TryParse(Console.ReadLine(), out taskID))
            {
                ParametrizedThreadCls tcls = new ParametrizedThreadCls();
                tcls.taskID = taskID;
                Thread thread = new Thread(new ThreadStart(tcls.PrintTask));
                thread.Start();
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Unable to convert");
            }
        }
    }

    public class ParametrizedThreadCls
    {
        public int taskID {  get; set; }

        public void PrintTask()
        {
            Console.WriteLine(taskID + " is running.");
        }
    }
}
