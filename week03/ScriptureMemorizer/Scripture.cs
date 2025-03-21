using System;
using System.Linq;
using System.Collections.Generic;

public class Scripture
{
    public Reference ScriptureReference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, string text)
    {
        ScriptureReference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public string GetDisplayText()
    {
        return string.Join(" ", Words.Select(w => w.ToString()));
    }

    public bool HideRandomWord()
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0)
            return false;  

        Random random = new Random();
        var wordToHide = visibleWords[random.Next(visibleWords.Count)];
        wordToHide.Hide();
        return true;
    }
}
