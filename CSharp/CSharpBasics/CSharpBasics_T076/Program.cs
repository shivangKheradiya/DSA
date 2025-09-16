using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T076
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer(){ ID = 1, Name = "A", Salary = 5000 };
            Customer b = new Customer(){ ID = 2, Name = "B", Salary = 3000 };
            ExCustomer c = new ExCustomer(){ ID = 3, Name = "C", Salary = 4000 };
            ExCustomer d = new ExCustomer(){ ID = 4, Name = "D", Salary = 4000 };

            List<Customer> lstCust = new List<Customer>();
            lstCust.Add(a);
            lstCust.Add(b);

            List<ExCustomer> lstExCust = new List<ExCustomer>();
            lstExCust.Add(c);
            lstExCust.Add(d);

            List<Customer> allCust = new List<Customer>();
            allCust.AddRange(lstCust);
            allCust.AddRange(lstExCust);
            
            List<Customer> rangeCust = allCust.GetRange(0,3);
            allCust.InsertRange(0,rangeCust);
            allCust.RemoveAt(0);
            allCust.RemoveRange(0,2);
            allCust.Clear();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class ExCustomer: Customer
    {
    }
}
