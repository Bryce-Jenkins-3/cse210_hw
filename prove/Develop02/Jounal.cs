using System;

public class Journal
{
    public List<string> prompts = new List<string>();
    public List<Entry> entries = new List<Entry>();

    public void NewEntry()
    {
        Entry entry = new Entry();
        entry.getentry();
        journal.entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void saveFile()
    {

    }

    public void loadFile()
    {
        
    }
}