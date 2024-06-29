using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your Last name: ");
        string lname = Console.ReadLine();

        // Concate Syntax
        Console.WriteLine("Hiii... How are you " + name + " ?");
        // Placeholder Syntax
        Console.WriteLine("Hope all good with you {0} {1}!!!", name, lname);

        // Verbatim Literals Syntax
        Console.WriteLine($"What can i do for you {name} ?");
    }
}
