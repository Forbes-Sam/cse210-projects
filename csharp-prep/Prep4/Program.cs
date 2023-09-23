// Samuel Forbes
// CSE 210
// Prep 4 assinment
// this program collects numbers from the user and saves it as a 
// list and calculates the total, average and the largest number.
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> sfNumbers = new List<int>();
        int sfNumberInput = 1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (sfNumberInput != 0)
        {
            Console.Write("Enter a number: ");
            string sfString = Console.ReadLine();
            sfNumberInput = int.Parse(sfString);

            sfNumbers.Add(sfNumberInput);
        }

        int sfSum = 0;
        int sfLargest = 0;
        foreach (int sfNum in sfNumbers)
        {
            sfSum = sfSum + sfNum;
            
            if (sfNum > sfLargest)
            {
                sfLargest = sfNum;
            }
        }

        float sfAverage = sfSum / sfNumbers.Count;

        Console.WriteLine($"The sum is: {sfSum}");
        Console.WriteLine($"The average is: {sfAverage}");
        Console.WriteLine($"The largest number is: {sfLargest}");

    }
}