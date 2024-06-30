using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please Enter A number (0-6):");
        int num;
        int.TryParse(Console.ReadLine(), out num);

        // Switch Case Statement Use
        switch (num)
        {
            case 0:
                Console.WriteLine("Num is Zero");
                break;
            case 1:
                Console.WriteLine("Num is One");
                break;
            case 2:
                Console.WriteLine("Num is Two");
                break;
            case 3:
                Console.WriteLine("Num is Three");
                break;
            case 4:
                Console.WriteLine("Num is Four");
                break;
            // Combined Case
            case 5:
            case 6:
                Console.WriteLine("Num is Five or Six.");
                break;
            default:
                Console.WriteLine("A number is not in range (0-6).");
                break;
        }
    }
}
