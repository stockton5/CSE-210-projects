using System;

class Program
{
    static void Main(string[] args)
    {
        int number;

        Random randomNumber = new Random();
        int real = randomNumber.Next(1, 101);

        do

        {
            Console.Write("What is the magic number?");
            number = int.Parse(Console.ReadLine());

            if (number < real)
            {
                Console.WriteLine("Higher");
            }
            else if (number > real)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }

        while (number != real);
        {

        }



    }

}