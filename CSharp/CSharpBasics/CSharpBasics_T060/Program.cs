using System;
using System.Text;

namespace CSharpBasics_T060
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strObject = " a";    // New Memory object 1: a
            strObject += " b";          // New Memory object 2: a b
            strObject += " c";          // New Memory object 3: a b c
            strObject += " d";          // New Memory object 4: a b c d

            // Now GC will clear these immutable objects

            StringBuilder sb = new StringBuilder();
            sb.Append(" a"); // Same Mutable object updated
            sb.Append(" b"); // Same Mutable object updated
            sb.Append(" c"); // Same Mutable object updated
            sb.Append(" d"); // Same Mutable object updated
        }
    }
}
