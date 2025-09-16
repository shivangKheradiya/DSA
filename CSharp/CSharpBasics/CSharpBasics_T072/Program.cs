using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T072
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Customer> dictCust = new Dictionary<int, Customer>();
            Customer a = new Customer(){ ID = 1, Name = "A", Salary = 5000 };
            Customer b = new Customer(){ ID = 2, Name = "B", Salary = 3000 };
            Customer c = new Customer(){ ID = 3, Name = "C", Salary = 4000 };
            dictCust.Add(a.ID,a);
            dictCust.Add(b.ID,b);
            dictCust.Add(c.ID,c);

            foreach (KeyValuePair<int, Customer> item in dictCust)
            {
                Console.WriteLine("ID : "+ item.Key + " , Name : " + item.Value.Name);               
            }

            foreach (Customer cust in dictCust.Values)
            {
                Console.WriteLine("ID : "+ cust.ID + " , Name : " + cust.Name);               
            }

            Console.WriteLine("Member with ID 1 :" + dictCust[1].Name);
            Console.WriteLine("Member with Name B :" + dictCust.FirstOrDefault(x=>x.Value.Name == "B").Value.ID );
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
