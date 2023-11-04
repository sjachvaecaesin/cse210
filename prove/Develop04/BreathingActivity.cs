class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _type = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Breathe()
    {
        Intro();
        Console.Clear();
        DisplayStart();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_length);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            for (int i = 4; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(" ");
                    break;
                }
                else
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }
            }
            Console.WriteLine();

            Console.Write("Now breathe out...");
            for (int i = 6; i >= 0; i--)
            {
                if (i == 0)
                {
                    Console.Write(" ");
                    break;
                }
                else
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b");
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        DisplayEnd();
    }
}