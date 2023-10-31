//Samuel Forbes
//some of the code that i got for this program was Maushams program for this project
//CSE 210
// Scripture memorizer
using System;

class Reference
{
    private string sfGetReference;
    private string sfGetText;

    public string sfReference()
    {
        Console.Write("What is the scripture reference? ");
        sfGetReference = Console.ReadLine() ;
        
        return sfGetReference;
    }
    public string sfGetPrompt()
    {
        Console.Write("What is the scripture? ");
        sfGetText = Console.ReadLine();

        return sfGetText;
    }
}