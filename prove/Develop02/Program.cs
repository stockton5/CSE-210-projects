using System;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        Prompt promptList = new Prompt();
        string choice = "";

        while(choice != "5")
        {
            Console.WriteLine("Please select one of the following");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                Console.Write("Enter the date: ");
                string date = Console.ReadLine();

                string question = promptList.GetRandomPrompt();
                Console.WriteLine(question);
                Console.Write("Your response: ");
                string response = Console.ReadLine();

                journal.AddEntry(date, $"{question}\n{response}");
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                journal.LoadFromFile();
            }
            else if (choice == "4")
            {
                journal.SaveToFile();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                Console.WriteLine("Please enter a number: ");
            }
        }
    }
}