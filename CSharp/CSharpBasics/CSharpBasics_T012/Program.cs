using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the coffee Shop... ");
        string result;
        int totalCost = 0;

        // Goto Statement usecase
        NeedMoreCoffee:
        Console.WriteLine("Plese Select your coffee size : 1. Small, 2. Medium, 3. Large");
        int cNum = int.Parse(Console.ReadLine());

        switch (cNum)
        {
            case 1:
                totalCost += 1;
                break;
            case 2:
                totalCost += 2;
                break;
            case 3:
                totalCost += 3;
                break;
            default:
                Console.WriteLine("Your Choice is not valid.");
                break;
        }

        AskAgain:
        Console.WriteLine("Do you need more coffee ? (Y/N)");
        result = Console.ReadLine();
        switch (result.ToUpper())
        {
            case "Y":
                // Goto Statement usecase
                goto NeedMoreCoffee;
            case "N":
                Console.WriteLine($"Your Total Cost is : {totalCost} $");
                break;
            default:
                Console.WriteLine("Your choice is not valid");
                // Goto Statement usecase
                goto AskAgain;
        }
    }
}

