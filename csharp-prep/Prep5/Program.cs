using System;

class Program
{
    static void Main(string[] args) {
        Welcome();

        string Name = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int favoriteNumberSquared = SquareNumber(favoriteNumber);

        int yearOfBirth;
        PromptUserBirthYear(out yearOfBirth);

        DisplayResult(Name, favoriteNumberSquared, yearOfBirth);
    }

    static void Welcome() {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName() {


        Console.Write("Please enter your name: ");
        string inputName = Console.ReadLine();
        return inputName;
    }

    static int PromptUserNumber() {
        Console.Write("Please enter your favorite number: ");
        int pickedNumber = int.Parse(Console.ReadLine());
        return pickedNumber;
    }

    static void PromptUserBirthYear(out int yearOfBirth) {
        Console.Write("Please enter the year you were born: ");
        yearOfBirth = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int value) {
        int squared = value * value;
        return squared;
    }

    static void DisplayResult(string user, int squaredValue, int birthYear) {
        Console.WriteLine($"{user}, the square of your number is {squaredValue}.");
        Console.WriteLine($"{user}, you will turn {2025 - birthYear} years old this year.");
    }
}
