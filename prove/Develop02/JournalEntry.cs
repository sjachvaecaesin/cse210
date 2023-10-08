class JournalEntry
{
    public string _prompt;
    public string _response;
    public DateTime _date = DateTime.Now;

    public string GeneratePrompt()
    {
        string[] promptList = {"Who was the most interesting person I interacted with today?", "What was the best part of my day?", 
                                "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", 
                                "What was one food you were craving today?", "What was the most dangerous part of your day today?", 
                                "What was the most exciting part of your day today?", "What was one thing that disappointed you today?"};
        
        var rnd = new Random();
        int index = rnd.Next(promptList.Length);
        _prompt = promptList[index];
        
        return _prompt;
    }
}
