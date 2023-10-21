using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private string sfText;
    private List<Word> sfWords;
    private string sfReference;
    
    public Scripture()
    {
        sfText = "";
        sfWords = new List<Word>();
        sfReference = "";
    }

    public Scripture(string text, string reference)
    {
        sfText = text;
        sfReference = reference;
        sfWords = new List<Word>();
        
        string[] wordsArray = text.Split(" ");
        foreach (string word in wordsArray)
        {
            sfWords.Add(new Word(word));
        }
    }

    public string sfToString()
    {
        List<string> displayWords = new List<string>();
        foreach(Word word in sfWords)
        {
            displayWords.Add(word.sfHideOrShow());
        }
        return $"{sfReference}: {string.Join(" ", displayWords)}";
        
    }
}