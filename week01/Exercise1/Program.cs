using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string fname = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lname = Console.ReadLine();

        string Fullname = fname + " " + lname;
        Console.WriteLine($"Your name is {lname}, {Fullname}.");
    }
}