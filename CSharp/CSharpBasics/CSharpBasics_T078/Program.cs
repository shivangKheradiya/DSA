using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T078
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

            lstCust.Sort();
            lstCust.Reverse();

            SortByName sbn = new SortByName();
            lstCust.Sort(sbn);
        }
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        // Compare by Salary. It's possible to compare by name
        int IComparable<Customer>.CompareTo(Customer other)
        {
            return Salary.CompareTo(other.Salary); // compare will give 3 result, -1/0/1
        }
    }

    public class SortByName: IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
