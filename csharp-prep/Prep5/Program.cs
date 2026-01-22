using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program.");
        }
        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string username = Console.ReadLine();
            return username;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int usernumber = int.Parse(Console.ReadLine());
            return usernumber;
        }
        static int SquareNumber(int usernumber)
        {
            int squarednumber = usernumber * usernumber;
            return squarednumber;
        }
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name} your number squared is {number}.");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squarednumber = SquareNumber(number);
        DisplayResult(name, squarednumber);
    }
}