using System;

namespace CSharpBasics_T019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Marvel.Character IronMan = new Marvel.Character();
            IronMan.FName = "Robert";
            IronMan.LName = "Downey Jr.";
            IronMan.Id = 1;
            IronMan.PrintFullName();

            Marvel.Character Hulk = new Marvel.Character("Bruce");
            Hulk.PrintFullName();

            Character CaptainAmerica = new Character(2, "Chris", "Evans");
            CaptainAmerica.PrintFullName();

            Character character = new Character();
            character.PrintFullName();
        }
    }
}

namespace Marvel
{
    public class Character
    {
        public Character() { }

        public Character(int id, string fname, string lname) 
        {
            this.Id = id;
            this.LName = lname;
            this.FName = fname;
        }

        // Constructor with default/ Optional parameter
        public Character(string fname, string lname = "No Lname")
        {
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