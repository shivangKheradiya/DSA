using System;

class Program
{
    static void Main()
    {
        int a, b;
        bool aConverted, bConverted, abConverted, abConvertedSuccessfully;
        Console.WriteLine("Enter Number A (Between 1-5):");
        aConverted = int.TryParse(Console.ReadLine(), out a);
        Console.WriteLine("Enter Number B (Between 1-5):");
        bConverted = int.TryParse(Console.ReadLine(), out b);

        // Boolean logical OR / bitwise logical OR
        abConverted = aConverted & bConverted;

        // Conditional or operator
        abConvertedSuccessfully = a != 0 && b != 0;

        // Method 1
        if (abConverted && abConvertedSuccessfully)
        {
            Console.WriteLine("A :" + a);
            Console.WriteLine("B :" + b);
        }
        else
        {
            Console.WriteLine("Something is going wrong");
        }

        // Method 2
        if (abConverted)
        {
            if (abConvertedSuccessfully)
            {
                Console.WriteLine("A :" + a);
                Console.WriteLine("B :" + b);
            }
            else
            {
                Console.WriteLine("Something is going wrong"); 
            }
        }
        else
        {
            Console.WriteLine("A or B or A & B are Not Converted Successfully.");
        }

        // Method 3
        if (abConvertedSuccessfully)
        {
            Console.WriteLine("A :" + a);
            Console.WriteLine("B :" + b);
        }
        else if (!abConverted)
        {
            Console.WriteLine("A or B or A & B are Not Converted Successfully.");
        }
        else
        {
            Console.WriteLine("Something is going wrong");
        }
    }
}

