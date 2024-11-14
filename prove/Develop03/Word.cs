using System;

public class Word 
{
    //It can contains text. It can also hide or reveal itself.
    private string text;
    private Boolean isHidden;   

    public Word(string text)
    {
        this.text = text;
        isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public void Reveal()
    {
        isHidden = false;
    }

    public string GetText()
    {
        if(!isHidden)
        {
            return text;
        }
        else
        {
            return new string('-', text.Length);
        }
    }

    public Boolean IsHidden()
    {
        return isHidden;
    }
}