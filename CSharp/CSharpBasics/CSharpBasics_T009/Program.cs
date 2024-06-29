using System;

class Program
{
    static void Main()
    {
        // ctrl + k , ctrl + c
        // Console.WriteLine("Single Line Comment");

        /* Console.WriteLine("Multi Line Comment");
           Console.WriteLine("Multi Line Comment");
           Console.WriteLine("Multi Line Comment");
           Console.WriteLine("Multi Line Comment");
        */

        SampleFucForXMLComment();
    }

    /// <summary>
    /// This is Sample Function for demostrating xml comments
    /// </summary>
    private static void SampleFucForXMLComment()
    {
        Console.WriteLine("XML Comment Method");
    }
}

