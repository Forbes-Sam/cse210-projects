// Journal
// This program is designed to store journal entries 
//
// 
// 2023
using System;

class Journal
{

    public List<string> sfReadFile(string sfFile)
    {
        string sfFileName = sfFile;
        string [] sfLines = System.IO.File.ReadAllLines(sfFileName);
        List<string> sfReturnList = new List<string>();
        
        foreach (string sfLine in sfLines)
        {
            string[] sfParts = sfLine.Split(",");
            string sfJournalEntry = (sfParts[0] + sfParts[1]);

            sfReturnList.Add(sfJournalEntry);
        }
        return sfReturnList;
    }
}