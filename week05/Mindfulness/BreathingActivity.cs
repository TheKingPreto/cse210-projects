using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        Start();

        int time = 0;
        while (time < _duration)
        {
            Console.Write("Breathe in... ");
            ShowCountdown(3);
            time += 3;
            if (time >= _duration) break;

            Console.Write("Breathe out... ");
            ShowCountdown(3);
            time += 3;
        }

        End();
    }
}