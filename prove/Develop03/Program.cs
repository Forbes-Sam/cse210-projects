//Sam Forbes
//A lot of the code that I got for this program was with Maushams help from his program for this project
//CSE 210
// Scripture memorizer
using System;

class Program {
    static void Main(string[] args) {
        Console.Clear();

        Reference reference = new Reference();
        string mb_reference =reference.sfGetPrompt();
        string mb_text =reference.sfReference();


        Scripture scripture = new Scripture(mb_text, mb_reference);

        while (!scripture.AreAllWordsHidden()) {
            Console.Clear();
            Console.WriteLine(scripture.sfToString());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input=="quit") {
                break;
            }

            scripture.HideRandomWord();
        }
    }

}