using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T089
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Task ID Number :");
            object taskID = Console.ReadLine();

            ParametrizedThreadCls tcls = new ParametrizedThreadCls();
            Thread thread = new Thread(new ParameterizedThreadStart(tcls.PrintTask));
            thread.Start(taskID);
            Thread.Sleep(5000);
        }
    }

    public class ParametrizedThreadCls
    {
        public void PrintTask(object i)
        {
            int taskID;
            int.TryParse(i.ToString(), out taskID);
            Console.WriteLine( taskID + " is running.");
        }
    }
}
