using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percent grade? ");
        string sfPercentInput = Console.ReadLine();
        float sfGrade = float.Parse(sfPercentInput);

        if (sfGrade >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (sfGrade >= 80)
        {
            Console.WriteLine("You have an B");
        } 
        else if (sfGrade >= 70)
        {
            Console.WriteLine("You have an C");
        } 
        else if (sfGrade >= 60)
        {
            Console.WriteLine("You have an D");
        } 
        else if (sfGrade < 60)
        {
            Console.WriteLine("You have an F");
        } 
        else
        {
            Console.WriteLine("Not a valid input");
        }

    }
}