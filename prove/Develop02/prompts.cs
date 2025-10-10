using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> questions = new List<string>()
    {
        "What was the best part of your day?",
        "What challenge did you face today?",
        "What are you grateful for?",
        "What did you learn today?",
        "What’s one goal for tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(questions.Count);
        return questions[index];
    }
}