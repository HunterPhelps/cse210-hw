using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int MagicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine($"Guess the magic number 1-100");
        int number = 0;
        int guess = 0;
        while (MagicNumber != number)
        { 
            Console.Write($"What is your guess? ");
            number = int.Parse(Console.ReadLine());
            if (MagicNumber > number)
            {
                Console.WriteLine("Higher");
            }
            else if (MagicNumber < number)
            {
                Console.WriteLine("Lower");
            }
            guess = guess + 1;
        }
        Console.WriteLine($"You're Correct! You got it in {guess} guesses.");
    }
}