using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        string letter = "";

        Console.Write("What is your grade as a percentage?");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {

            letter = "A";
        }
        else if (grade >= 80)
        {

            letter = "B";
        }
        else if (grade >= 70)
        {

            letter = "C";

        }
        else
        { Console.WriteLine("Sorry you have failed the course, please retake the course to get credit"); }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70)
        { Console.WriteLine("Congrats you passed!"); }

        }
            
         }
    
