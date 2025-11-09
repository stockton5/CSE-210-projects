using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflectionQuestions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
                       "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void DoActivity()
    {
        DoStartingMessage();
        Console.Clear();

        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];
        Console.WriteLine($"Consider the following prompt:\n\n--- {prompt} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue...");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on the following questions as they relate to this experience:\n");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _reflectionQuestions[rand.Next(_reflectionQuestions.Count)];
            Console.WriteLine($"> {question}");
            _SpinnerAnimation(5);
            Console.WriteLine();
        }

        DoEndingMessage();
    }
}