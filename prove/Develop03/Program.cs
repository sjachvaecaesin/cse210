//    I've created the program to specifications, while including a system that allows the user to input their own scriptures to practice with,
// in addition to a system that allows them to choose how many words they wish to remove each iteration (easy = 2 words, medium = 4, hard = 6).

class Program
{
    static void Main(string[] args)
    {
        string userScripture;
        string book;
        int chapter;
        int verseStart;
        int verseEnd;
        string input = "";
        int difficulty = 4;

        while (input.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Scripture Memorizer, what would you like to do?");
            Console.WriteLine("1 - Start with a premade scripture.");
            Console.WriteLine("2 - Input your own scripture of choice.");
            Console.WriteLine("3 - Quit");
            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            if (input == "1")
            {
                Scripture scripture = new Scripture();
                Console.Write("Please choose the difficulty for memorization (easy, medium, hard): ");
                input = Console.ReadLine();

                if (input.ToLower() == "easy")
                {
                    difficulty = 2;
                }
                else if (input.ToLower() == "medium")
                {
                    difficulty = 4;
                }
                else if (input.ToLower() == "hard")
                {
                    difficulty = 6;
                }

                Console.Clear();
                scripture.DisplayScripture();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                input = Console.ReadLine();

                while (!scripture.Hidden())
                {
                    if (input.ToLower() == "quit")
                    {
                        break;
                    }
                    else
                    {
                        scripture.HideWords(difficulty);
                        Console.Clear();
                        scripture.DisplayScripture();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                        input = Console.ReadLine();
                    }
                }
            }
            else if (input == "2")
            {
                Console.Write("Please enter the book: ");
                book = Console.ReadLine();
                Console.Write("Please enter the chapter: ");
                chapter = int.Parse(Console.ReadLine());
                Console.Write("Please enter the starting verse: ");
                verseStart = int.Parse(Console.ReadLine());
                Console.Write("Please enter the finishing verse, or enter 0 if there isn't one: ");
                verseEnd = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the content of the Scripture(s), with ';' seperating any verses:");
                userScripture = Console.ReadLine();

                Console.Write("Please choose the difficulty for memorization (easy, medium, hard): ");
                input = Console.ReadLine();

                if (input.ToLower() == "easy")
                {
                    difficulty = 2;
                }
                else if (input.ToLower() == "medium")
                {
                    difficulty = 4;
                }
                else if (input.ToLower() == "hard")
                {
                    difficulty = 6;
                }

                if (verseEnd == 0)
                {
                    Scripture scripture = new Scripture(userScripture, book, chapter, verseStart);

                    Console.Clear();
                    scripture.DisplayScripture();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                    input = Console.ReadLine();

                    while (!scripture.Hidden())
                    {
                        if (input.ToLower() == "quit")
                        {
                            break;
                        }
                        else
                        {
                            scripture.HideWords(difficulty);
                            Console.Clear();
                            scripture.DisplayScripture();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                            input = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Scripture scripture = new Scripture(userScripture, book, chapter, verseStart, verseEnd);

                    Console.Clear();
                    scripture.DisplayScripture();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                    input = Console.ReadLine();

                    while (!scripture.Hidden())
                    {
                        if (input.ToLower() == "quit")
                        {
                            break;
                        }
                        else
                        {
                            scripture.HideWords(difficulty);
                            Console.Clear();
                            scripture.DisplayScripture();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

                            input = Console.ReadLine();
                        }
                    }
                }
            }
            else if (input == "3")
            {
                input = "quit";
            }

            Console.Clear();
        }
    }
}