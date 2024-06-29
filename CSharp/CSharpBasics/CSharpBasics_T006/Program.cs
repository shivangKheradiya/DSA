using System;

class Program
{
    static void Main()
    {
        // Value Types - int, float, double, structs, enums Etc...
        // Referenece Types - Interfaces, Class, Deligates, Arrays, String Etc..

        // string is reference type
        string text = null;
        Console.WriteLine("text :" + text);
        // Below line will give error 
        // int i = null;
        // To avoid the error we can use Nullable operator 
        int? i = null;
        bool? b = null;
        bool bTrueResult = b == true;
        bool bFalseResult = b == false;
        bool bNullResult = b == null;
        
        // Avoid Null Collision with typeCasting
        int number = i == null ? 0: (int)i;
        // Avoid Null Collision with Null Collision operator
        number = i ?? 0;

        Console.WriteLine("i :" + i);
        Console.WriteLine("bTrueResult :" + bTrueResult);
        Console.WriteLine("bFalseResult :" + bFalseResult);
        Console.WriteLine("bNullResult :" + bNullResult);
        Console.WriteLine("number :" + number);
    }
}

