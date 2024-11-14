using System;

public class Prompts
{
    public static List<string> values = ["Who was the most interesting person I interacted with today?",
                                    "What was the best part of my day?",
                                    "How did I see the hand of the Lord in my life today?",
                                    "What was the strongest emotion I felt today?",
                                    "If I had one thing I could do over today, what would it be?"];

    public static void Add()
    {
        Console.Write("What prompt do you want to add? ");
        string newprompt = Console.ReadLine();
        values.Add(newprompt);
    }
}