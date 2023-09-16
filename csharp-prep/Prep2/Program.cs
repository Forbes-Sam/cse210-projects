using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percent grade? ");
        string sfPercentInput = Console.ReadLine();
        float sfGrade = float.Parse(sfPercentInput);

        string sfLetter = "unknown";

        if (sfGrade >= 90)
        {
            sfLetter = "A";
        }
        else if (sfGrade >= 80)
        {
            sfLetter = "B";
        } 
        else if (sfGrade >= 70)
        {
            sfLetter = "C";
        } 
        else if (sfGrade >= 60)
        {
            sfLetter = "D";
        } 
        else if (sfGrade < 60)
        {
            sfLetter = "F";
        } 
        else
        {
            Console.WriteLine("Not a valid input");
        }
        Console.WriteLine($"Your grade is a {sfLetter}");

        if (sfGrade >= 70)
        {
            Console.WriteLine($"You passed");
        }
        else
        {
            Console.WriteLine("Sorry you didnt pass");
        }

    }
}