using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Intel";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Console.WriteLine(job1._jobTitle);
        Console.WriteLine(job1._company);
        Console.WriteLine(job1._startYear);
        Console.WriteLine(job1._endYear);
        Console.WriteLine();

        Job job2 = new Job();
        job2._jobTitle = "Cracker Jack Packager";
        job2._company = "CJ INC.";
        job2._startYear = 2017;
        job2._endYear = 2019;

        Console.WriteLine(job2._jobTitle);
        Console.WriteLine(job2._company);
        Console.WriteLine(job2._startYear);
        Console.WriteLine(job2._endYear);
        Console.WriteLine();

        job1.Display();
        job2.Display();
        Console.WriteLine();

        Resume myResume = new Resume();
        myResume._name = "Hunter Phelps";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
        Console.WriteLine();
    }
}