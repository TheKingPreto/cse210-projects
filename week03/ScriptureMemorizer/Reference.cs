using System;
using System.Collections.Generic;

public class Reference
{
    public string ReferenceText { get; private set; }
    public List<string> VerseRange { get; private set; }

    public Reference(string reference)
    {
        this.ReferenceText = reference;
        this.VerseRange = ParseReference(reference);
    }

    private List<string> ParseReference(string reference)
    {
        string[] parts = reference.Split(":");
        List<string> verseRange = new List<string>();

        if (parts.Length == 1)
        {
            verseRange.Add(parts[0]);
        }
        else if (parts.Length == 2)
        {
            string[] rangeParts = parts[1].Split("-");
            verseRange.Add(parts[0]);
            verseRange.AddRange(rangeParts);
        }
        return verseRange;
    }

    public override string ToString()
    {
        if (VerseRange.Count == 1)
            return $"{ReferenceText}";
        return $"{ReferenceText}:{VerseRange[1]}";
    }
}
