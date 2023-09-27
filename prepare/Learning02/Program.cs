using System;

class Program
{
    static void Main(string[] args)
    {
        Job first = new Job();
        Job second = new Job();

        first._company = "Microsoft";
        second._company = "Apple";

        first._jobTitle = "Software Engineer";
        second._jobTitle = "IT Specialist";

        first._startYear = 2000;
        second._startYear = 2020;

        first._endYear = 2019;
        second._endYear = 2039;

        Resume myResume = new Resume();

        myResume._name = "Allison Rose";
        myResume._jobs.Add(first);
        myResume._jobs.Add(second);

        myResume.Display();
    }
}