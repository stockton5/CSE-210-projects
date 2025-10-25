using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rand = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void Display()
    {
        Console.WriteLine(_reference.GetDisplayText());
        Console.WriteLine();

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWords()
    {
        int wordsToHide = _rand.Next(2, 5); 

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = _rand.Next(_words.Count);
            _words[index].Hide();
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
