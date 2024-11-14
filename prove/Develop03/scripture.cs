using System;

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

        Random randomGenerator = new Random();
        Verse verse = verses[randomGenerator.Next(0, verses.Count())];
        word = verse.HideRandomWord();
        hiddenWords.Add(word);
    }

    public void RevealLastHiddenWord()
    {
        Word word = hiddenWords[hiddenWords.Count() - 1];
        word.Reveal();
        hiddenWords.Remove(word);
    }

    public List<Verse> GetVerses()
    {
        return verses;
    }
}