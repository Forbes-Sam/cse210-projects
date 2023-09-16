using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string sfFirst = Console.ReadLine();

        Console.Write("What is your last name? ");
        string sfLast = Console.ReadLine();

        Console.WriteLine($"Your name is {sfLast}, {sfFirst} {sfLast}");
    }
}