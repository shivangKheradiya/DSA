using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");

        int TargetNum = int.Parse(Console.ReadLine());
        int[] ints = new int[TargetNum + 1];

        // For loop
        for (int Start = 0; Start <= TargetNum; Start++)
        {
            Console.WriteLine("For loop with i:" + Start);
            ints[Start] = Start;
        }

        // For Each loop
        foreach (int num in ints)
        {
            Console.WriteLine("For each loop with i:" + num);
        }

        // For Each break loop
        foreach (int num in ints)
        {
            Console.WriteLine("For each break loop with i:" + num);
            if (num == 3)
                break;
        }

        // For break loop
        for (int Start = 0; Start <= TargetNum; Start++)
        {
            Console.WriteLine("For break loop with i:" + Start);
            if (Start == 3)
                break;
        }

        // For Each continue loop
        foreach (int num in ints)
        {
            if (num % 2 == 0)
                continue;
            Console.WriteLine("For each continue loop with i:" + num);
        }

        // For continue loop
        for (int Start = 0; Start <= TargetNum; Start++)
        {
            if (Start % 2 == 0)
                continue;
            Console.WriteLine("For continue loop with i:" + Start);
        }
    }
}
