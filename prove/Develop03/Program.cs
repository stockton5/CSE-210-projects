using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.\n");

        string userInput = "";

        while (userInput.ToLower() != "quit" && !scripture.AllWordsHidden())
        {
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press ENTER to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "quit")
            {
                scripture.HideRandomWords();
            }
        }

        Console.Clear();
        if (scripture.AllWordsHidden())
        {
            Console.WriteLine("All words are hidden!");
        }
    }
}