using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T075
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

            bool containB = lstCust.Contains(b);
            bool exist = lstCust.Exists(x=>x.Salary> 3000);
            Customer custB = lstCust.Find(x=>x.Name == "B");
            Customer custD = lstCust.FindLast(x=>x.Salary == 4000);
            List<Customer> cust4000 = lstCust.FindAll(x=>x.Salary == 4000);
            int idx = lstCust.FindIndex(x=>x.Salary == 4000);
            int idy = lstCust.FindLastIndex(x=>x.Salary == 4000);

            Customer[] custArray = lstCust.ToArray();
            Dictionary<int, Customer> custArray = lstCust.ToDictionary(cst => cst.ID, cst => cst);
        }

        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
    }
}
