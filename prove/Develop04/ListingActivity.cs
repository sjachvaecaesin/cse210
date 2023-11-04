class ListingActivity : Activity
{
    protected string[] _prompts = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    protected List<string> _responses = new List<string>{};

    public ListingActivity()
    {
        _type = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Listing()
    {
        Intro();
        Console.Clear();
        DisplayStart();
        Console.WriteLine();

        Random rng = new Random();
        int prompt = rng.Next(_prompts.Count());
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[prompt]} ---");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
        Console.WriteLine();

        DisplayList();
        Console.WriteLine();
        DisplayEnd();
    }

    private void DisplayList()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_length);

        while (DateTime.Now < endTime)
        {
        Console.Write("> ");
        _responses.Add(Console.ReadLine());
        }
        
        Console.WriteLine($"You listed {_responses.Count()} items!");
    }
}