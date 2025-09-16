using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CSharpBasics_T080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer(){ ID = 1, Name = "A", Salary = 5000 };
            Customer b = new Customer(){ ID = 2, Name = "B", Salary = 3000 };
            Customer c = new Customer(){ ID = 3, Name = "C", Salary = 4000 };
            Customer d = new Customer(){ ID = 4, Name = "D", Salary = 4000 };
            
            List<Customer> lstCust = new List<Customer>(2);
            lstCust.Add(a);
            lstCust.Add(b);
            lstCust.Add(c);
            lstCust.Add(d);

            List<bool> TFAll = lstCust.TrueForAll(x=> x.Salary >= 5000);
            ReadOnlyCollection<Customer> ReadOnlyLst = lstCust.AsReadOnly();

            // Reallocate and copy to minimum size
            lstCust.TrimExcess();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
