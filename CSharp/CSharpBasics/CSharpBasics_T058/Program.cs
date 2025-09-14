using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T058
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customerA = new Customer("S", "K");
            Customer customerB = new Customer("S", "K");

            Console.WriteLine(customerB.Equals(customerA));
            Console.WriteLine(customerB == customerA);
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
        
        public override bool Equals(object customerA)
        {
            if (customerA == null) return false;
            if (!(customerA is Customer) ) return false;
            return (this.Name == ((Customer)customerA).Name && ((Customer)customerA).LastName == this.LastName);
        }

        // It's written just to remove warnings
        public override int GetHashCode() { 
            return this.Name.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
