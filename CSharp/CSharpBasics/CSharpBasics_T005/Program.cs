using System;

class Program
{
    static void Main()
    {
        float a, b, add, reminder;
        bool gt, eq, neq, ge;
        bool isSumEq10;

        // Assignment Operator
        a = 5;
        b = 7;

        // Comparator Operator
        gt = a > b;

        // Equality Operator
        eq = a == b;
        neq = a != b;

        // Logical Operator
        ge = a > b || a == b;

        // Additive Operator
        add = a + b;
        reminder = a%b;

        // Ternary operator
        isSumEq10 = add == 10 ? true : false; 

        Console.WriteLine("Add : " + add);
        Console.WriteLine("Reminder : " + reminder);
        Console.WriteLine("Greater Than : " + gt);
        Console.WriteLine("Greater Than or Equals : " + ge);
        Console.WriteLine("Eqals : " + eq);
        Console.WriteLine("Not Eqals : " + neq);
        Console.WriteLine("IsSumEq10 : " + isSumEq10);

        /// References Documentation
        /// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
    }
}

