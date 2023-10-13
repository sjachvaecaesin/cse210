//     Technically speaking, provided the journal entries were saved using the program or in the format the program reads from, you could save
// the file as .csv or .json or .txt, potentially as whatever kind of file you list it as. Only problem with that is that I don't expect the
// program to read from those other file formats like .csv or .json. Hence, I don't expect to be getting 100% from that, but wouldn't mind being
// proven wrong on that front. Other than that, I have nothing to report and believe I have completed the program to specifications.

class Program
{
    static void Main(string[] args)
    {
        string name;
        Journal myJournal = new Journal();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                JournalEntry input = new JournalEntry();
                Console.WriteLine(input.GeneratePrompt());
                input._response = Console.ReadLine();
                myJournal._journalEntries.Add(input);
            }
            else if (choice == "2")
            {
                myJournal.DisplayJournalEntries();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                name = Console.ReadLine();
                myJournal.SaveJournalEntries(name);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                name = Console.ReadLine();
                myJournal = LoadEntry(name);
            }
        }
    }

    static Journal LoadEntry(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        Journal journal = new Journal();

        int len = lines.Length;
        int numEntries = len / 3;

        for (int entries = 0; entries < numEntries; entries++)
        {
            JournalEntry temp = new JournalEntry();
            for (int x = 0; x < 3; x++)
            {
                string[] parts = lines[x + entries * 3].Split(" | ");

                foreach (string part in parts)
                {
                    if (x == 0)
                    {
                        temp._date = DateTime.Parse(parts[0].Substring(6));
                        temp._prompt = parts[1].Substring(8);
                    }
                    else if (x == 1)
                    {
                        temp._response = part;
                    }
                    else if (x == 2)
                    {
                        journal._journalEntries.Add(temp);
                    }
                }
            }
        }

        return journal;
    }
}