using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(string date, string text)
    {
        Entry entry = new Entry(date, text);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries yet");
        }
        else
        {
            Console.WriteLine("Journal Entries");
            foreach (Entry e in entries)
            {
                Console.WriteLine(e);
            }
        }
    }

    public void SaveToFile(string filename = "journal.txt")
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry e in entries)
            {
                writer.WriteLine(e.ToFileString());
            }
        }
        Console.WriteLine($" Journal saved to {filename}");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the file name: ");
        string filename = Console.ReadLine();

        entries.Clear();

        string[] fileLines = File.ReadAllLines(filename);

        foreach (string line in fileLines)
        {
            Entry entry = Entry.FromFileString(line);
            entries.Add(entry);
        }

        Console.WriteLine($"{entries.Count} entries loaded from '{filename}'.");
    }
}