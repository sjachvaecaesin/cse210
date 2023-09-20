using System;

class Program
{
    static void Main(string[] args)
    {
        Random rng = new Random();
        int magic = rng.Next(1, 101);

        Console.Write("What is your guess? ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);

        while (guess != magic)
        {
            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.WriteLine("");

            Console.Write("What is your guess? ");
            input = Console.ReadLine();
            guess = int.Parse(input);
        }

        Console.WriteLine("You guessed it!");
    }
}