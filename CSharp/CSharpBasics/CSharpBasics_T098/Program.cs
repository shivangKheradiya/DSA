using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T098
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

            // Created a parameter for find method
            Predicate<Customer> customerPredicate = new Predicate<Customer>(FindCustomer);

            // Found the result
            Customer result = listCust.Find( cus => customerPredicate(cus) );

            // Same use case for anonymouse methods
            result = listCust.Find( delegate(Customer cstmr) 
            { 
                return cstmr.ID == 2; 
            } );
            
            //Same things can be implimented button click event
        }

        public static bool FindCustomer(Customer cust){
            return cust.ID == 2;
        }
    }
    
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
