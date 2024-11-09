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
        Console.Write("What is the date? ");
        DateTime theCurrentTime = DateTime.now;
        date = theCurrentTime.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"{date}: {entry}");
    }
}