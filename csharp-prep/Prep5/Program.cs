//Sam Forbes
//CSE 210
//Prep 5 assinment
// this program uses functions that gets the users name and favorite 
// number than calculates the square and displays it back to the user

using System;
class Program
{
        static void sfDisplayWelcome ()
        {
            Console.WriteLine("Welcome to program");
        }

        static string sfPromptUserName ()
        {
            Console.Write("What is your name: ");
            string sfName = Console.ReadLine();

            return sfName;
        }

        static int sfPromptUserNumber ()
        {
            int sfNum = 0;
            Console.Write("What is your Favorite number?: ");
            string sfNumInput = Console.ReadLine();
            sfNum = int.Parse(sfNumInput);

            return sfNum;
        }

        static double sfSquareNumber (int sfNumber)
        {
            double sfSquareRoot = Math.Sqrt(sfNumber);

            return sfSquareRoot;
        }

        static void sfDisplayResult (string sfName, double sfNumber)
        {
            Console.WriteLine($"{sfName}, the square of your number is {sfNumber}");
        }

        static void Main(string[] args)
        {
            sfDisplayWelcome();
            string sfName = sfPromptUserName();
            int sfNumber = sfPromptUserNumber();
            double sfNumberSquared = sfSquareNumber(sfNumber);
            sfDisplayResult(sfName, sfNumber);
            
        }
    
}