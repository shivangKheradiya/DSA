using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStudent student = new Student(); // It works similar to polymorphysm
            student.Name = "Test";
            student.Id = 1;
            // student.LastName = "Test"; is not possible because student variable is of type IStudent
            student.print();

            // IStudent student = new IStudent(); is not possible
        }
    }

    public interface IStudent // Contains only decleration
    {
        string Name { get; set; } //It's public by default
        int Id { get; set; }

        // int id; Fields are not possible for interfaces
        void print();
    }

    public interface HasLastName
    {
        string LastName { get; set; }
    }

    public interface IExtStudent : HasLastName, IStudent // Interfaces can inherrite from more than one interface
    {

    }

    public class ExtStudent : IExtStudent // Interfaces can have all inherrite methods from all the interface
    {
        public string LastName { get ; set ; }
        public string Name { get ; set ; }
        public int Id { get ; set ; }

        public void print()
        {
            Console.WriteLine(Name + " has ID " + Id);
        }
    }

    // public interface IExtStudent : Student { } interface can't inheritate from class

    // Iterface implimentation must match all the methods signature from interface
    // Class Allows multiple interface inheritance 
    public class Student : IStudent , HasLastName
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string LastName { get; set ; }

        public void print()
        {
            Console.WriteLine(Name + " has ID " + Id);
        }
    }
}
