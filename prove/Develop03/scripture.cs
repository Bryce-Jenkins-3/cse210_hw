using System;
using System.ComponentModel.DataAnnotations;

class Scripture
{
    //Scripture contains instances of verses. It can also tell verses to hide a word.
    private List<Verse> verses;
    private List<Word> hiddenWords;

    public Scripture(List<Verse> verses)
    {
        this.verses = verses;
        this.hiddenWords = new List<Word>();
    }

    public void HideRandomWord()
    {
        // revisit later
        Word word;
        do
        {
        Random randomGenerator = new Random();
        Verse verse = verses[randomGenerator.Next(0, verses.Count())];
        word = verse.HideRandomWord();
        } while (hiddenWords.Contains(word));

        hiddenWords.Add(word);
    }

    public void RevealLastHiddenWord()
    {
        if (hiddenWords.Count() > 0)
        {
            Word word = hiddenWords[hiddenWords.Count() - 1];
            word.Reveal();
            hiddenWords.Remove(word);
        }
    }

    public List<Verse> GetVerses()
    {
        return verses;
    }

    public void Display()
    {
                foreach(Verse verse in verses)
        {
            foreach(Word word in verse.GetWords())
            {
                Console.Write(word.GetText() + " ");
            }
            Console.WriteLine();
        }
    }
}