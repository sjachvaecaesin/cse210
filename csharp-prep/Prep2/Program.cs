using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        Console.WriteLine();
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "A" || letter == "F")
        {
            Console.WriteLine($"Your grade is an {letter}.");
        }
        else
        {
            Console.WriteLine($"Your grade is a {letter}.");
        }

        if (grade >= 70)
        {
            Console.Write("Congratulations on passing!");
        }
        else
        {
            Console.Write("You didn't pass the course. Better luck next time.");
        }
    }
}