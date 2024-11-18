using System;

class Program
{
    static void Main(string[] args)
    {
        Reference memory = new Reference("2 Nephi", 2, 25, 26);
        Console.WriteLine(memory.GetReference());

        string verse1 = "Adam fell that men might be; and men are, that they might have joy.";
        string verse2 = "And the Messiah cometh in the fulness of time, that he may redeem the children of men from the fall. And because that they are redeemed from the fall they have become free forever, knowing good from evil; to act for themselves and not to be acted upon, save it be by the punishment of the law at the great and last day, according to the commandments which God hath given.";
        string[] parts = verse1.Split();
        string[] parts2 = verse2.Split();

        List<Word> words1 = new List<Word>();
        List<Word> words2 = new List<Word>();
        foreach(string part in parts)
        {
            words1.Add(new Word(part));
        }

        foreach(string part in parts2)
        {
            words2.Add(new Word(part));
        }

        List<Verse> verses = new List<Verse>();
        verses.Add(new Verse(words1));
        verses.Add(new Verse(words2));

        Scripture scripture = new Scripture(verses);

        string quit;
        Console.Write("Press enter to continue or enter quit to quit: ");
        quit = Console.ReadLine();     
           
        while (quit != "quit")
        {
            Console.Write("Press enter to continue or enter quit to quit: ");
            quit = Console.ReadLine();
            while (true)
            {
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    scripture.HideRandomWord();
                    Console.Clear();
                    scripture.Display();
                    break;
                }
                else if (Console.ReadKey(true).Key == ConsoleKey.Backspace)
                {
                    scripture.RevealLastHiddenWord();
                    Console.Clear();
                    scripture.Display();
                    break;
                }
            }
        }
    }
}