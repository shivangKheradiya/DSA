using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T052
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.add(5, 5);
        }
    }

    public class Calculator
    {
        // [Obsolete("Use add(List<int> args) method", true)]  use this if you wish to show error
        [Obsolete("Use add(List<int> args) method")]
        public int add(int a, int b)
        {
            return a + b;
        }

        public int add(List<int> args)
        {
            int sum = 0;
            foreach (int a in args)
            {
                sum += a;
            }
            return sum;
        }
    }
}
