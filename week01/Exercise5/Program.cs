using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine(); 
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int favoriteNumber))
            {
                return favoriteNumber; 
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is: {squaredNumber}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();

        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(name, squaredNumber);
    }
}