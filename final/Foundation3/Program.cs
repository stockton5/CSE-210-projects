using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Address address2 = new Address("456 Center Ave", "Salt Lake City", "UT", "USA");
        Address address3 = new Address("789 Park Rd", "Boise", "ID", "USA");

        List<Event> events = new List<Event>();

        events.Add(new Lecture(
            "AI and the Future",
            "A discussion on artificial intelligence trends",
            "April 10, 2026",
            "6:00 PM",
            address1,
            "Dr. Jane Smith",
            150
        ));

        events.Add(new Reception(
            "Company Networking Night",
            "Meet and connect with industry leaders",
            "May 5, 2026",
            "7:00 PM",
            address2,
            "rsvp@events.com"
        ));

        events.Add(new OutdoorGathering(
            "Summer Festival",
            "Food, music, and fun outdoors",
            "June 20, 2026",
            "12:00 PM",
            address3,
            "Sunny with light winds"
        ));

        foreach (Event ev in events)
        {
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("SHORT DESCRIPTION");
            Console.WriteLine(ev.GetShortDescription());
        }
    }
}