using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {


        List<int> number_list = new List<int>() { };
        int number;
        int sum = 0;



        do
        {

            Console.Write("Enter a list of numbers, type 0 when finished.");

            string userResponse = Console.ReadLine();
            number = int.Parse(userResponse);


            if (number != 0)
            {
                number_list.Add(number);
            }


        }
        while (number != 0);

        
        int max = number_list[0];

        foreach (int numberss in number_list)
        {
            Console.WriteLine(numberss);
            sum += numberss;

            if (max < numberss) max = numberss;

        }

        double avg = sum / number_list.Count;
        Console.WriteLine($"The total sum is: {sum}");
        Console.WriteLine($"The average is {avg}");
        Console.WriteLine($"The max is {max}");
        
    }
}