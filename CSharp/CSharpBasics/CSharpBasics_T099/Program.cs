using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T099
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> listCust = new List<Customer>();
            Customer a = new Customer(){ ID = 1, Name = "A", Salary = 5000 };
            Customer b = new Customer(){ ID = 2, Name = "B", Salary = 3000 };
            Customer c = new Customer(){ ID = 3, Name = "C", Salary = 4000 };
            listCust.Add(a);
            listCust.Add(b);
            listCust.Add(c);

            // Found the result
            Customer result = listCust.Find( cust => cust.ID == 2 );
            int count = listCust.Count(cst=> cst.Salary> 3000 );

            // Deligate(Anonymouse methods) can be rewritten with lambda 
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
