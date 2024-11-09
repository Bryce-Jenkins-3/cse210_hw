using System;

public class Entry
{
    public string entry;
    public string date;
    public string prompt;

    public void getentry()
    {
        prompt = "What was great about today?";
        Console.WriteLine(prompt);
        entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        date = theCurrentTime.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"{date}: {entry}");
    }
}