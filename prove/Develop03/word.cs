// Samuel Forbes
// This code is so much fun
//CSE 210
// Scripture memorizer
using System;

class Word
{
    private string sfText;
    private bool sfIsHidden;
    public Word(string text)
    {
        sfText = text;
        sfIsHidden = false;
    }
    public void sfShow()
    {
        sfIsHidden = false;
    }
    public void sfHide()
    {
        sfIsHidden = true;
    }
    public bool sfGetHidden()
    {
        return sfIsHidden;
    }
    public string sfHideOrShow()
    {
        if (sfIsHidden)
        {
            return "_______";
        }
        return sfText;
    }
    
}