using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T079
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

            // Method 1
            Comparison<Customer> custComparison = new Comparison<Customer>(ComparisonByID);
            lstCust.Sort(custComparison);
            
            // Method 2
            lstCust.Sort(delegate (Customer x, Customer y) {
                return x.ID.CompareTo(y.ID);
            });

            // Method 3
            lstCust.Sort((x,y)=> x.ID.CompareTo(y.ID));
        }

        public static int ComparisonByID<in Customer>(Customer x, Customer y){
            return x.ID.CompareTo(y.ID);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
