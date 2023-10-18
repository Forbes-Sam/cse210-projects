//Samuel Forbes
using System;

class Reference
{
    private string sfGetReference;
    private string sfGetText;
    private List <string> sfResponse = new List <string>();

    public Reference()
    {
        sfGetReference = "";
        sfGetText = "";

    }
    public List<string> sfGetPrompt()
    {
        Console.Write("What is the scripture reference? ");
        sfGetReference = Console.ReadLine() ;

        Console.Write("What is the scripture? ");
        sfGetText = Console.ReadLine();

        sfResponse.Add(sfGetReference);
        sfResponse.Add(sfGetText);
        
        return sfResponse;
    }
}