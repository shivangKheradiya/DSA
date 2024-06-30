using System;

class Program
{
    static void Main()
    {
        // Instance Method Example
        Program program = new Program();
        program.Print();
        program.Print(10);
        Console.WriteLine($"Instance Method Called with double number {program.RetunDouble(50)}");

        // Static Method can't be called in instance of the program class
        // program.main();          gives error
        // program.StaticPrint();   gives error
        Program.StaticPrint();
        Program.StaticPrint(50);
        Console.WriteLine($"Static Method Called with triple number {Program.RetunTriple(50)}");
    }

    // Instance Methods Example
    public void Print()
    {
        Console.WriteLine("Instance Method Called");
    }

    public void Print(int num)
    {
        Console.WriteLine($"Instance Method Called with number {num}");
    }

    public int RetunDouble(int num)
    {
        return 2 * num;
    }

    // Static Methods Example
    public static void StaticPrint()
    {
        Console.WriteLine("Static Method Called");
    }

    public static void StaticPrint(int num)
    {
        Console.WriteLine($"Static Method Called with number {num}");
    }

    public static int RetunTriple(int num)
    {
        return 3 * num;
    }
}

