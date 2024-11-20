// Scripture.cs
using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor
    public Scripture(Reference reference, string scriptureText)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        // Split the scripture text into words and initialize Word objects
        string[] splitWords = scriptureText.Split(' ');
        foreach (string word in splitWords)
        {
            // Remove punctuation for accurate hiding
            string cleanWord = word.Trim(new char[] { '.', ',', ';', ':', '!', '?' });
            _words.Add(new Word(cleanWord));
        }
    }

    // Method to display the complete scripture
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference.GetReferenceString());
        foreach (Word word in _words)
        {
            Console.Write(word.Display() + " ");
        }
        Console.WriteLine("\n");
    }

    // Method to hide a random word
    public void HideRandomWord()
    {
        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        if (visibleIndices.Count > 0)
        {
            int indexToHide = visibleIndices[_random.Next(visibleIndices.Count)];
            _words[indexToHide].Hide();
        }
    }

    // Method to check if all words are hidden
    public bool AllWordsHidden()
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
}
