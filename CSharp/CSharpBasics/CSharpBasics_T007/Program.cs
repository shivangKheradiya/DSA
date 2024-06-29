using System;

class Program
{
    static void Main()
    {
        int i;
        float j;
        string num = "12499.5ser";
        i = 100;

        // Implicite Conversion : System Automatically converts Without loss of data or error
        j = i;

        // Explicite Conversion : Manually need to convert
        i = (int)j;
        Console.WriteLine(i + " is right result.");

        // Explicite Conversion without error but giving wrong result
        j = 1249999999999999999999999.5f;
        i = (int)j;
        Console.WriteLine(i + " is wrong result.");

        // Explicite Conversion using Convert Class it gives error
        try
        {
            i = Convert.ToInt32(j);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Parse & TryParse
        try
        {
            i = int.Parse(num);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        bool isSuccessful = int.TryParse(num, out i);
        Console.WriteLine("isSuccessful : " + isSuccessful);
        Console.WriteLine(i + " is value for i.");
    }
}

