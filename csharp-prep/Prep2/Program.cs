using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string PercentageString = Console.ReadLine();
        int percentage = int.Parse(PercentageString);

        string grade = "N/A";
        if (percentage >= 90)
        {
            grade = "A";
        }
        else if (percentage >= 80)
        {
            grade = "B";
        }
        else if (percentage >= 70)
        {
            grade = "C";
        }
        else if (percentage >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        if (percentage >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass. Better luck next time.");
        }
        Console.WriteLine($"You got a {grade}");
    }
}