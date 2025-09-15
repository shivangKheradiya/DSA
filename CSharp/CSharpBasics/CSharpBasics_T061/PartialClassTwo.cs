using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T061
{
    public partial class PartialClass
    {
        public string Name { get; set; }

        public void Print()
        {
            Console.WriteLine("ID: " + this.ID + "; Name: " + this.Name);
        }
    }
}
