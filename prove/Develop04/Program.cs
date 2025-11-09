using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program Menu");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.DoActivity();
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.DoActivity();
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity();
                listing.DoActivity();
            }
            else if (choice == "4")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("\nInvalid selection. Press Enter to try again.");
                Console.ReadLine();
            }
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program!");
    }
}