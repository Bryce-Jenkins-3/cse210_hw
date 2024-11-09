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