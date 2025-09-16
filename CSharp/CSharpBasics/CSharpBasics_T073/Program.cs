using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T073
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer(){ ID = 1, Name = "A", Salary = 5000 };
            Customer b = new Customer(){ ID = 2, Name = "B", Salary = 3000 };
            Customer c = new Customer(){ ID = 3, Name = "C", Salary = 4000 };

            Dictionary<int, Customer> dictCust = new Dictionary<int, Customer>();
            Customer[] CustArray = new Customer[3];
            CustArray[0] = a;
            CustArray[1] = b;
            CustArray[2] = c;

            dictCust.Add(a.ID, a);
            dictCust.Add(b.ID, b);
            dictCust.Add(c.ID, c);

            foreach (KeyValuePair<int, Customer> item in dictCust)
            {
                Console.WriteLine("ID : "+ item.Key + " , Name : " + item.Value.Name);
            }

            foreach (Customer cust in dictCust.Values)
            {
                Console.WriteLine("ID : "+ cust.ID + " , Name : " + cust.Name);
            }

            Console.WriteLine("Member with ID 1 :" + dictCust[1].Name);
            Console.WriteLine("Member with Name B :" + dictCust.FirstOrDefault(z => z.Value.Name == "B").Value.ID) ;
            Console.WriteLine("Member with salary > 3K :" + dictCust.Count(y => y.Value.Salary > 3000) );
            
            Customer x;
            if (dictCust.TryGetValue(3, out x ))
            {
                Console.WriteLine("Member with ID 3 :" + x.Name);
            }else
            {
                Console.WriteLine("No Key Member found");
            }

            dictCust = CustArray.ToDictionary( p => p.ID, q=>q );
            CustArray = dictCust.Values.ToArray<Customer>();
            List<Customer> lstCust = dictCust.Values.ToList();
            Console.WriteLine("Member with Name B :"  );

            dictCust.Remove(3);
            dictCust.Clear();
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
