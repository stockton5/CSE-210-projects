using System;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Resume
{


    public string _firstName = "";
    public string _lastName = "";

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_firstName} {_lastName}");
        Console.WriteLine("Jobs:");

        foreach (Job jobe in _jobs) 
        {
            jobe.Display();
        }

    }




}
