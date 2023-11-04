class Activity
{
    protected string _type;
    protected int _length;
    protected string _description;

    protected void Loading(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");

                    Thread.Sleep(500);

                    Console.Write("\b");
                    Console.Write("..");

                    Thread.Sleep(500);

                    Console.Write("\b\b");
                    Console.Write("...");

                    Thread.Sleep(500);

                    Console.Write("\b");
                    Console.Write(" ");
                    Console.Write("\b\b");
                    Console.Write("  ");
                    Console.Write("\b\b\b");
                    Console.Write("   ");
                    Console.Write("\b\b\b");
                }
            }
    }

    protected void Intro()
    {
        Console.WriteLine($"Welcome to the {_type}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _length = int.Parse(Console.ReadLine());
    }

    protected void DisplayStart()
    {
        Console.WriteLine("Get ready...");
        Loading(3);
    }

    protected void DisplayEnd()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_length} seconds of the {_type}.");
        Loading(5);
    }
}