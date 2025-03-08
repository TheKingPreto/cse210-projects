using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers. Enter 0 to stop.");

        while (true)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out int number))
            {
                if (number == 0)
                {
                    break;
                }
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }

        if (numbers.Count > 0)
        {
            int sum = numbers.Sum();
            Console.WriteLine("\nThe sum is: " + sum);

            double average = numbers.Average(); 
            Console.WriteLine("The average is: " + average);

            int max = numbers.Max(); 
            Console.WriteLine("The largest number is: " + max);
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }

    }
}