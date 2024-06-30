using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics_T019
{
    public class Character
    {
        // Constructor with default parameter
        public Character() : this(0, "No FName", "No LName") { }

        public Character(int id, string fname, string lname)
        {
            this.Id = id;
            this.LName = lname;
            this.FName = fname;
        }

        public int Id { get; set; }

        public string FName { get; set; }

        public string LName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine($"{this.Id}. {FName} {LName}");
        }
        ~Character()
        {
            // It's used to clean the resouce hold by the class
            // This is Destructor It's Automatically triggered by Garbage collector
        }
    }
}
