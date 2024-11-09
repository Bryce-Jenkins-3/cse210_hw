using System;

public class Journal
{
    public List<string> prompts = new List<string>();
    public List<Entry> entries = new List<Entry>();

    public void newEntry()
    {

    }

    public void displayEntries()
    {
        Console.WriteLine($"{entries[0].date}: {entries[0].entry}");
    }

    public void saveFile()
    {

    }

    public void loadFile()
    {
        
    }
}