using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T057
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer("S", "K");
            Console.WriteLine(c.ToString());
        }
    }

    public class Customer
    {
        public Customer(string name, string lastname)
        {
            Name = name;
            LastName = lastname;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return (Name + " " + LastName);
        }
    }
}
