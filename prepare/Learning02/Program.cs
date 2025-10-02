using System;
using System.IO.Pipes;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._title = "Software Engineer";
        job1._company = "Micron";
        job1._duration = "2022-2024";
        job1.Display();

        Job job2 = new Job();
        job2._title = "Manager";
        job2._company = "Apple";
        job2._duration = "2013-2018";
        job2.Display();

        Resume resume1 = new Resume();
        resume1._firstName = "Stockton";
        resume1._lastName = "Hammer";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1.Display();


        


    }
}