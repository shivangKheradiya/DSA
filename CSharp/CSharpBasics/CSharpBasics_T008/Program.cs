using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Array Use Case
        string[] names = new string[3];
        names[0] = "A";
        names[1] = "B";
        names[2] = "C";

        Console.WriteLine("names Contains");
        foreach (string name in names) {
            Console.WriteLine(name);
        }
        Console.WriteLine("ArraySize is Fixed. \n");

        // List Use Case
        List<string> namesArray = new List<string>();
        namesArray.Add("A");
        namesArray.Add("B");
        namesArray.Add("C");

        Console.WriteLine("namesArray Contains");
        foreach (string name in namesArray)
        {
            Console.WriteLine(name);
        }
    }
}

