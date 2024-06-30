using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");

        // While loop example
        int TargetNum = int.Parse(Console.ReadLine());
        int Start = 0;

        while (Start <= TargetNum) { 
            Console.WriteLine("While loop with i:" + Start);
            Start++;
        }
    }
}

