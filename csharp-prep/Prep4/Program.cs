using System;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers then type 0 when you are finished.");
        int number = 1;
        int sum = 0;
        int largest = 0;
        int count = 0;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
                count = count + 1;
            }

        }
        foreach (int i in numbers)
            {
                sum = sum + i;
                if (i > largest)
                {
                    largest = i;
                }
            }
        float average = (float)sum / count;
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Largest number: {largest}");
    }
}