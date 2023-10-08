class Journal
{
    public List<JournalEntry> _journalEntries = new List<JournalEntry>();

    public void DisplayJournalEntries()
    {
        foreach (JournalEntry j in _journalEntries)
        {
            Console.WriteLine($"Date: {j._date.ToString("MM/dd/yyyy")} | Prompt: {j._prompt}");
            Console.WriteLine(j._response);
            Console.WriteLine();
        }
    }

    public void SaveJournalEntries(string name)
    {
        using (StreamWriter output = new StreamWriter(name))
        {
            foreach (JournalEntry j in _journalEntries)
            {
                output.WriteLine($"Date: {j._date.ToString("MM/dd/yyyy")} | Prompt: {j._prompt}");
                output.WriteLine(j._response);
                output.WriteLine();
            }
        }
    }
}