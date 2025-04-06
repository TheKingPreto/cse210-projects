using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself through this experience?",
        "How did you feel when it was complete?",
        "What could you learn from this experience that applies to other situations?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public override void Run()
    {
        Start();
        Random rand = new Random();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"> {_prompts[rand.Next(_prompts.Count)]}\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(3);

        int time = 0;
        while (time < _duration)
        {
            Console.WriteLine($"> {_questions[rand.Next(_questions.Count)]}");
            ShowSpinner(5);
            time += 5;
        }

        End();
    }
}