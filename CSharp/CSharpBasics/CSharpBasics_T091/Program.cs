using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics_T091
{
    public delegate void ThreadCallBackDeligate(int number);

    internal class Program
    {
        public int CallProperty { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Task ID Number :");
            int taskID;
            if (int.TryParse(Console.ReadLine(), out taskID))
            {
                ThreadCallBackDeligate tcbd = new ThreadCallBackDeligate(ThreadCallBackNumber);
                ParametrizedThreadCls tcls = new ParametrizedThreadCls();
                tcls.setTaskID(taskID, tcbd);
                Thread thread = new Thread(new ThreadStart(tcls.PrintTask));
                thread.Start();
                Thread.Sleep(5000);
            }
            else
            {
                Console.WriteLine("Unable to convert");
            }
        }

        public static void ThreadCallBackNumber(int number)
        {
            Console.WriteLine(number + " is output number.");
        }

    }

    public class ParametrizedThreadCls
    {
        ThreadCallBackDeligate _CallBackNumber;

        public int _taskID;

        public void setTaskID(int taskID, ThreadCallBackDeligate ReturnNumber)
        {
            _taskID = taskID;
            _CallBackNumber = ReturnNumber;
        }

        public void PrintTask()
        {
            Console.WriteLine( _taskID++ + " is running.");
            _CallBackNumber(_taskID);
        }
    }
}
