using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();

        int number;
        string letter = "";

        if (int.TryParse(grade, out number))
        {if (number >= 90)
            {
                letter = "A";
            }
            else if (number >= 80 && number < 90)
            {
                letter = "B";
            }
            else if (number >= 70 && number < 80)
            {
                letter = "C";
            }
            else if (number >= 60 && number < 70)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }

            Console.WriteLine($"Your letter grade is: {letter}");

            if (number >= 70)
            {
                Console.WriteLine("Congratulations!!! You passed!");
            }
            else
            {
                Console.WriteLine("Try again, next time you will definitely pass, don't give up :)");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}