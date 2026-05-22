// This is the main logic and word hiding

using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private Random _random = new Random();

    // This builds scripture from text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitWords = text.Split(' ');

        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        int index = _random.Next(_words.Count);
        _words[index].Hide();
    }

// This part checks if all words are hidden
    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    // This then builds full display output
        public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;
    }
}