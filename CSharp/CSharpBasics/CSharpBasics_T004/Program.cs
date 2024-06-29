using System;

class Program
{
    static void Main()
    {
        // Escape Sequence
        string text = "This's \"CSharpBasics\" tutorial.";

        // Escape Sequence
        text += "\nNew Line Escape Sequence" ;
        Console.WriteLine(text);

        // Verbatim Literals
        text = @"C:\GitHub_SK_Repo\DSA\CSharp\CSharpBasics\CSharpBasics_T4\";
        Console.WriteLine(text);

        /// Reference Documentation
        /// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
    }
}

