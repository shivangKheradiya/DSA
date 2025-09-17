using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T097
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. Of cores: " + Environment.ProcessorCount);

            // Don't exceed total number of process more than these count as processor overhead will degrades performace
        }
    }
}
