using System;
using System.Collections.Generic;
using System.Linq;

class word
{

    private static string _text;
    private static List<string> _hiddenWords;

    public word(string text)
    {
    
        _text = text;
        _hiddenWords = new List<string>();
    }


    public static void DisplayScripture()
    {
        Console.WriteLine(Reference.reference());
        string[] words = _text.Split(' ');
        foreach (string word in words)
        {
            if (_hiddenWords.Contains(word))
            {
                Console.Write("_____ ");
            }
            else
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine();
    }

    public static void HideWord()
    {
        string[] words = _text.Split(' ');
        Random rand = new Random();
        int index = rand.Next(words.Length);
        string wordToHide = words[index];
        _hiddenWords.Add(wordToHide);
    }

    public static bool AllWordsHidden()
    {
        string[] words = _text.Split(' ');
        return _hiddenWords.Count == words.Length;
    }
}