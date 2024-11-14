using System;

public class Verse 
{
    //Verse contains a list of words. It can tell word to hide itself.
    //It needs a method to hide a word called HideRandomWord. This should return the word.
    private List<Word> words;

    public Verse(List<Word> words)
    {
        this.words = words;
    }

    public Word HideRandomWord()
    {
        Random randomGenerator = new Random();
        Word word = words[randomGenerator.Next(0, words.Count())];
        word.Hide();
        return word;
    }

    public List<Word> GetWords()
    {
        return words;
    }
}