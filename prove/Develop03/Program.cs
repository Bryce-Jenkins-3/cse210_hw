using System;

class Program
{
    static void Main(string[] args)
    {
        Reference memory = new Reference("Proverbs", 3, 5);
        Console.WriteLine(memory.GetReference());

        List<Word> words = new List<Word>();
        words.Add(new Word("Hi"));
        words.Add(new Word("Hello"));
        words.Add(new Word("High"));

        List<Verse> verses = new List<Verse>();
        verses.Add(new Verse(words));
        verses.Add(new Verse(words));
        verses.Add(new Verse(words));

        Scripture scripture = new Scripture(verses);

        foreach(Verse verse in scripture.GetVerses())
        {
            foreach(Word word in verse.GetWords())
            {
                Console.Write(word.GetText() + " ");
            }
            Console.WriteLine();
        }

        scripture.HideRandomWord();
        scripture.HideRandomWord();

        foreach(Verse verse in scripture.GetVerses())
        {
            foreach(Word word in verse.GetWords())
            {
                Console.Write(word.GetText() + " ");
            }
            Console.WriteLine();
        }

        scripture.RevealLastHiddenWord();
        scripture.RevealLastHiddenWord();

        foreach(Verse verse in scripture.GetVerses())
        {
            foreach(Word word in verse.GetWords())
            {
                Console.Write(word.GetText() + " ");
            }
            Console.WriteLine();
        }
    }
}