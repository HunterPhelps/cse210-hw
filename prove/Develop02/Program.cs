using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal j = new Journal();
        WriteAndSave f = new WriteAndSave();
        int _userInput = 0;
        while (_userInput != 5)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Create Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string inputStr = Console.ReadLine();
            _userInput = int.Parse(inputStr);
            //Console.WriteLine(input);

            if(_userInput == 1)
                {
                    j.addEntry();
                }

            else if (_userInput == 2)
                {
                    Console.WriteLine();
                    j.displayEntries();
                }

            else if (_userInput == 3)
                {
                    f.loadFile(j);
                }

            else if (_userInput == 4)
                    {
                        f.writeFile(j.getEntry());
                    }
                    
            else if (_userInput == 5)
                {
                    Console.WriteLine("Have a nice day.");
                }
            else 
                {
                Console.WriteLine();
                Console.WriteLine("Invalid entry please enter a nummber between 1-5.");
                }
        }
    }
}