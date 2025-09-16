using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T077
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intLst = new List<int>() {5, 1, 6, 2, 10, 3};
            intLst.Sort();
            intLst.Reverse();

            List<string> stringLst = new List<string>() {"a", "S", "B", "w", "z"};
            stringLst.Sort();
            stringLst.Reverse();
        }
    }
}
