using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 50;
        Console.WriteLine($"Value for i is now {i}");

        // Pass By reference with ref keyword
        Program.ChangeNumberToDouble(ref i);
        Console.WriteLine($"Value for i is now {i}");

        i = 50;
        // Pass By reference with out keyword
        Program.ChangeNumberToDouble(i, out i);
        Console.WriteLine($"Value for i is now {i}");

        i = 50;
        // Pass by Value
        Program.PrintDouble(i);

        // Pass By Value with params
        int[] j = { 5, 6, 10 };
        Program.ParamsMethodUse(j);

        // Compilation error will not occur because of params keyword
        Program.ParamsMethodUse();

        // There is possibiliye to pass some values like below
        Program.ParamsMethodUse(1 , 2, 3, 5);
    }

    // Pass by Value
    private static void PrintDouble(int i)
    {
        Console.WriteLine($"Value for i is now {2 * i}");
    }

    // Pass By reference with ref keyword
    public static void ChangeNumberToDouble(ref int number)
    {
        number *= 2;
    }

    // more than one output parameters are also possible to define
    public static void ChangeNumberToDouble(int number, out int doublenum)
    {
        doublenum = number * 2;
    }

    // Params Array Must be the last in the parameters and it must be the only one 
    public static void ParamsMethodUse(params int[] args)
    {
        foreach (int item in args)
        {
            Console.WriteLine($"Param item is {item}");
        }
    }
}