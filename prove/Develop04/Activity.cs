using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity() { }
    public void DoStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nGet ready to begin...");
        _SpinnerAnimation(3);
    }

    public void DoEndingMessage()
    {
        Console.WriteLine("Well Done!");
        _SpinnerAnimation(3);
        Console.WriteLine($"You have completed anther {_duration} seconds of the {_name} Activity.");
        _SpinnerAnimation(3);
    }

    protected void _SpinnerAnimation(int duration)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }

    protected void _Countdown(int countFrom)
    {
        for (int i = countFrom; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}