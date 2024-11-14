using System;

public class Entry
{
    public string entry;
    public string date;
    public string prompt;

    Random randomGenerator = new Random();

    public void getentry()
    {
        prompt = Prompts.values[randomGenerator.Next(0, Prompts.values.Count())];
        Console.WriteLine(prompt);
        entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        date = theCurrentTime.ToShortDateString();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine($"{entry}\n");
    }
}