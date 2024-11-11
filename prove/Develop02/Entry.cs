using System;

public class Entry
{
    public string entry;
    public string date;
    public string prompt;
    public List<string> prompts = ["Who was the most interesting person I interacted with today?",
                                    "What was the best part of my day?",
                                    "How did I see the hand of the Lord in my life today?",
                                    "What was the strongest emotion I felt today?",
                                    "If I had one thing I could do over today, what would it be?"];

    Random randomGenerator = new Random();

    public void getentry()
    {
        prompt = prompts[randomGenerator.Next(1, prompts.Count())];
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