using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. " +
                       "Clear your mind and focus on your breathing.";
    }

    public void DoActivity()
    {
        DoStartingMessage();
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            _Countdown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            _Countdown(4);
            Console.WriteLine("\n");
        }

        DoEndingMessage();
    }
}