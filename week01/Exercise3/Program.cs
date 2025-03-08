using System;

class Program
{
    static void Main(string[] args)
    {
       Random random = new Random();

        int magicNumber = random.Next(1, 101);

        int guess = -1; 
        
        Console.WriteLine("Welcome to the Guessing Game!");
        Console.WriteLine("Try to guess the magic number between 1 and 100.");
        
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string guessInput = Console.ReadLine();
    
            if (!int.TryParse(guessInput, out guess))
            {
                Console.WriteLine("Please enter a valid number for your guess.");
                return;
            }


            if(guess == magicNumber)
            {
                Console.WriteLine("You guessed it!!");
            }
            else if(guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            Console.WriteLine("Higher");
        }    
    }
}