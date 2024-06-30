// Namespace Decleration
using System;
using WA = MyWork.A.WorkerA; // Alias Directives
using WB = MyWork.A.WorkerB;

class Program
{
    static void Main()
    {
        // Namespace Use Case
        WA.WorkA AA    = new WA.WorkA();
        WA.WorkA1 AA1  = new WA.WorkA1();
        WA.WorkA2 AA2  = new WA.WorkA2();

        // Fully Qualify Namespace can be used
        MyWork.A.WorkerB.WorkA BA    = new WB.WorkA();
        WB.WorkA1 BA1  = new WB.WorkA1();
        WB.WorkA2 BA2  = new WB.WorkA2();
    }
}

// Namespace Definations
namespace MyWork.A
{
    namespace WorkerA
    {
        public class WorkA
        {
            public WorkA()
            {
                Console.WriteLine("WorkerA.WorkA");
            }
        }

        public class WorkA1
        {
            public WorkA1()
            {
                Console.WriteLine("WorkerA.WorkA1");
            }
        }

        public class WorkA2
        {
            public WorkA2()
            {
                Console.WriteLine("WorkerA.WorkA2");
            }
        }
    }

    namespace WorkerB
    {
        public class WorkA
        {
            public WorkA()
            {
                Console.WriteLine("WorkerB.WorkA");
            }
        }

        public class WorkA1
        {
            public WorkA1()
            {
                Console.WriteLine("WorkerB.WorkA1");
            }
        }

        public class WorkA2
        {
            public WorkA2()
            {
                Console.WriteLine("WorkerB.WorkA2");
            }
        }
    }
}
