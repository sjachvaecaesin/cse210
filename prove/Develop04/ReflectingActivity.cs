class ReflectingActivity : Activity
{
    protected string[] _prompts = {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    protected List<string> _questions = new List<string> {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectingActivity()
    {
        _type = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Reflect()
    {
        Random rng = new Random();
        int prompt = rng.Next(_prompts.Count());
        Intro();
        Console.Clear();
        DisplayStart();
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {_prompts[prompt]} --- ");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        DisplayReflect();
        Console.WriteLine();
        DisplayEnd();
    }

    private void DisplayReflect()
    {
        List<string> temp = _questions;
        Random rng = new Random();
        int question = rng.Next(temp.Count());
        Console.Clear();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_length);

        while (DateTime.Now < endTime)
        {
        Console.Write($"> {temp[question]}");
        temp.RemoveAt(question);
        Loading(12);
        Console.WriteLine();
        }
    }
}