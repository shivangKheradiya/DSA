using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T049
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Customer
    {
        // Can access outside class
        private string name;

        // Can't access outside class 
        public string Name { get; set; }

        // Accessed by Derived Class
        protected int ID;
    }

    public class MyCustomer : Customer
    {
        public int getID()
        {
            return base.ID;
        }
    }
}
