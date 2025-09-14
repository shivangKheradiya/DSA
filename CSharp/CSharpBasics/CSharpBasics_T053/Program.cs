using System;
using System.Reflection;

namespace CSharpBasics_T053
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = Type.GetType("CSharpBasics_T053.Customer");
            // Type type = typeof(Customer);

            PropertyInfo[] propertyInfo = type.GetProperties();
            foreach (PropertyInfo info in propertyInfo)
            {
                Console.WriteLine(info.Name);
            }

            Console.WriteLine("Methods will be: ");
            foreach (MethodInfo info in type.GetMethods())
            {
                Console.WriteLine(info.Name);
            }

            Console.WriteLine("Constructors will be: ");
            foreach (ConstructorInfo info in type.GetConstructors())
            {
                Console.WriteLine(info.ToString());
            }
            Console.WriteLine("--------------------");
        }
    }

    public class Customer
    {
        public int MyProperty1 { get; set; }
        public string MyProperty2 { get; set; }

        public Customer() { }
        public void print() { }
    }
}
