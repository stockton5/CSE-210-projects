using System;

class Program
{
    static void Main(string[] args) //there has to be a main string
    {
        //     Console.WriteLine("Hello Prep1 World!"); // console.writeline = print function... has to end with semicolon
        //                                              // when naming variables we us PascalCase and mainly camelCase
        //                                              // have to use double quotes for strings
        //                                              // python store variable 'first_name = "Bob"
        //     string firstName = "Bob";
        //     // console.WriteLine("hello" + firstName);
        //     Console.WriteLine($"Hello {firstName}");

        //     // fav_color = input("What is your favorite color?")  python example

        //     Console.Write("What is your favorite color?");
        //     string favoriteColor = Console.ReadLine(); //add a quetion mark after string to return null
        //     Console.WriteLine($"{firstName}, your favorite color is {favoriteColor}");

        //     Console.Write("How old are you?");
        //     int age = int.Parse(Console.ReadLine()); // allows you to store as an integer
        //     Console.WriteLine($"{firstName} , you are {age} years old ");

        //     int a = 13;
        //     int b = 7;

        //     int c = a + b;

        //     Console.WriteLine($"{c} is c");
        //     Console.WriteLine($"{a / b} is a/b"); // this will give you an int but you want a decimal
        //     Console.WriteLine($"{(double)a / b}"); // this is how to get a decimal

        //     double x = 1.5; // this is how to declare a decimal
        //     float y = 1.5f; // you have to put f on the end of a float

        //     bool isDone = false; // how to boolean in c#endregion

        //     if (isDone)
        //     {
        //         Console.WriteLine("All done");
        //     }
        //     else
        //     {
        //         Console.WriteLine("Not done yet.");
        //         }


        Console.Write("What is your first name?");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName}{lastName}");

     }
}