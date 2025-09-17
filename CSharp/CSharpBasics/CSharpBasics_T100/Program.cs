using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T100
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

            Func<Customer, string> selector = cust => cust.Name + " is name." ;

            IEnumerable<string> names = listCust.Select(selector);
            // IEnumerable<string> names = listCust.Select(cust => cust.Name + " is name." );

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Func<int, int, string> funcSum = (firstNum, secNum) => "Sum : " + ( firstNum + secNum ).ToString();
            Console.WriteLine(funcSum(10,20));
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
