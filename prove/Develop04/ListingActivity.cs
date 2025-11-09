using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life " +
                       "by having you list as many things as you can in a certain area.";
    }

    public void DoActivity()
    {
        DoStartingMessage();
        Console.Clear();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"List as many responses as you can to the following prompt:\n- {prompt} -");
        Console.Write("\nYou may begin in: ");
        _Countdown(5);
        Console.WriteLine("\n");

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
        }

        Console.WriteLine($"\nYou listed {responses.Count} items.");
        DoEndingMessage();
    }
}