using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer(){ ID = 1, Name = "A", Salary = 5000 };
            Customer b = new Customer(){ ID = 2, Name = "B", Salary = 3000 };
            Customer c = new Customer(){ ID = 3, Name = "C", Salary = 4000 };
            MyCustomer d = new MyCustomer(){ ID = 4, Name = "D", Salary = 4000 };

            List<Customer> lstCust = new List<Customer>(2);
            lstCust.Add(a);
            lstCust.Add(b);
            lstCust.Add(c);
            lstCust.Insert(1,d);

            foreach (Customer cst in lstCust)
            {
                Console.WriteLine("ID : "+ cst.ID + " , Name : " + cst.Name);
            }

            Console.WriteLine("Member with ID 1 :" + lstCust[0].Name);
            Console.WriteLine("Member with Index 3 :" + lstCust.IndexOf(d));
        }
    }
    
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

    public class MyCustomer : Customer
    {
    }
}
