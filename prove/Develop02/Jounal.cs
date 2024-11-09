using System;

public class Journal
{
    public List<string> prompts = new List<string>();
    public List<Entry> entries = new List<Entry>();

    public void NewEntry()
    {
        Entry entry = new Entry();
        entry.getentry();
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveFile()
    {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName));
        {
            foreach(Entry entry in entries)
            {
                outputFile.WriteLine($"{entry.date}: {entry.entry}");
            }
        }
    }

    public void LoadFile()
    {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
    }
}