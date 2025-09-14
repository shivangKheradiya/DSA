using System;
using System.Reflection;

namespace CSharpBasics_T055
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type type = assembly.GetType("CSharpBasics_T055.Customer");

            string[] param = { "Shivang", "Kheradiya" };
            // If constructor is not defined with param, we can avoid params
            object customerInstance = Activator.CreateInstance(type,param);
            
            MethodInfo methodInfoPrint = type.GetMethod("print");
            // If method is not defined with param, we can avoid params
            methodInfoPrint.Invoke(customerInstance, param);
        }
    }

    public class Customer
    {
        public Customer(string name, string lastname) {
            Name = name;
            LastName = lastname;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public void print(string name, string lastname)
        {
            Console.WriteLine(Name + " " + LastName);
        }
    }
}
