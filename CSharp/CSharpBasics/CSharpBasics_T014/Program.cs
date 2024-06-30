using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");

        int TargetNum = int.Parse(Console.ReadLine());
        int Start = 0;

        // Do While loop
        do
        {
            Console.WriteLine("Do While loop with i:" + Start);
            Start++;
        } while (Start <= TargetNum);
    }
}
