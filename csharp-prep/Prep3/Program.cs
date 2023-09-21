// Sam Forbes
// CSE 210
// This program generates a random number between 1-100 and has the user guess until they get the correct answer

using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int sfMagicNumber = randomGenerator.Next(1, 101);

        Boolean incorrect = true;
        while (incorrect)
        {

            Console.Write("What do you think the magic number is 1-100? ");
            string sfGuessInput = Console.ReadLine();
            int sfGuess = int.Parse(sfGuessInput);

            if (sfGuess == sfMagicNumber)
            {
                incorrect = false;
                Console.WriteLine($"You got it the magic number is {sfMagicNumber}");
            }
            else if (sfGuess >= sfMagicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (sfGuess <= sfMagicNumber)
            {
                Console.WriteLine("higher");
            }

        }
    }
}