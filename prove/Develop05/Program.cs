class Program
{
    static List<Goal> goals = new List<Goal>();
    static int total = 0;
    static void Main(string[] args)
    {
        string input = "";
        string choice;
        string name;
        string desc;
        int score;
        int bonus;
        int milestone;
        int index;

        while (input != "6")
        {
            if (total >= 1000)
            {
                Console.WriteLine( ":**********************:");
                Console.WriteLine($":You have {total} points!!:");
                Console.WriteLine( ":**********************:");
                Console.WriteLine( "|                      |");
                Console.WriteLine( "|                      |");
                Console.WriteLine();

                Console.WriteLine("Menu Options: ");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        desc = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        score = int.Parse(Console.ReadLine());

                        SimpleGoal goal = new SimpleGoal(name, desc, score);
                        goals.Add(goal);
                    }
                    else if (choice == "2")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        desc = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        score = int.Parse(Console.ReadLine());

                        EternalGoal goal = new EternalGoal(name, desc, score);
                        goals.Add(goal);
                    }
                    else if (choice == "3")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        desc = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        score = int.Parse(Console.ReadLine());

                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        milestone = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        bonus = int.Parse(Console.ReadLine());

                        ChecklistGoal goal = new ChecklistGoal(name, desc, score, bonus, milestone);
                        goals.Add(goal);
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal.GoalToString());
                    }
                    Console.WriteLine();
                }
                else if (input == "3")
                {
                    Save(total);
                    Console.WriteLine();
                }
                else if (input == "4")
                {
                    Console.Write("What is the filename for the goal file? ");
                    choice = Console.ReadLine();
                    Console.WriteLine();
                    Load(choice);
                }
                else if (input == "5")
                {
                    int i = 1;
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine($"{i}. {goal.GetGoal()}");
                        i++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    index = int.Parse(Console.ReadLine());

                    Goal test = goals[index-1];
                    total += test.Complete();
                }
            }
            else
            {
                Console.WriteLine($"You have {total} points");
                Console.WriteLine();

                Console.WriteLine("Menu Options: ");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        desc = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        score = int.Parse(Console.ReadLine());

                        SimpleGoal goal = new SimpleGoal(name, desc, score);
                        goals.Add(goal);
                    }
                    else if (choice == "2")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        desc = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        score = int.Parse(Console.ReadLine());

                        EternalGoal goal = new EternalGoal(name, desc, score);
                        goals.Add(goal);
                    }
                    else if (choice == "3")
                    {
                        Console.Write("What is the name of your goal? ");
                        name = Console.ReadLine();

                        Console.Write("What is a short description of it? ");
                        desc = Console.ReadLine();

                        Console.Write("What is the amount of points associated with this goal? ");
                        score = int.Parse(Console.ReadLine());

                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        milestone = int.Parse(Console.ReadLine());

                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        bonus = int.Parse(Console.ReadLine());

                        ChecklistGoal goal = new ChecklistGoal(name, desc, score, bonus, milestone);
                        goals.Add(goal);
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goal.GoalToString());
                    }
                    Console.WriteLine();
                }
                else if (input == "3")
                {
                    Save(total);
                    Console.WriteLine();
                }
                else if (input == "4")
                {
                    Console.Write("What is the filename for the goal file? ");
                    choice = Console.ReadLine();
                    Console.WriteLine();
                    Load(choice);
                }
                else if (input == "5")
                {
                    int i = 1;
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine($"{i}. {goal.GetGoal()}");
                        i++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    index = int.Parse(Console.ReadLine());

                    Goal test = goals[index-1];
                    total += test.Complete();
                }
            }
        }
    }

    static void Save(int total)
    {
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        SimpleGoal simpleTest = new SimpleGoal("","",0);
        EternalGoal eternalTest = new EternalGoal("","",0);
        ChecklistGoal checklistTest = new ChecklistGoal("","",0,0,0);

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(total);
            foreach (Goal goal in goals)
            {
                if (object.ReferenceEquals(goal.GetType(), simpleTest.GetType()))
                {
                    output.WriteLine($"{goal.GetGoal()} | {goal.GetDesc()} | {goal.GetScore()} | {goal.GetDone()}");
                }
                else if (object.ReferenceEquals(goal.GetType(), eternalTest.GetType()))
                {
                    output.WriteLine($"{goal.GetGoal()} | {goal.GetDesc()} | {goal.GetScore()}");
                }
                else if (object.ReferenceEquals(goal.GetType(), checklistTest.GetType()))
                {
                    output.WriteLine($"{goal.GetGoal()} | {goal.GetDesc()} | {goal.GetScore()} | {goal.GetBonus()} | {goal.GetMilestone()} | {goal.GetCurrent()}");
                }
            }
        }
    }

    static void Load(string file)
    {
        string[] lines = File.ReadAllLines(file);
        total = int.Parse(lines[0]);
        int len = lines.Length;
        List<Goal> temp = new List<Goal>(goals);

        if (goals.Count() != 0)
        {
            foreach (Goal goal in temp)
            {
                goals.Remove(goal);
            }
        }

        for (int i = 1; i < len; i++)
        {
            string[] line = lines[i].Split(" | ");
            if (line.Length == 4)
            {
                SimpleGoal goal = new SimpleGoal(line[0], line[1], int.Parse(line[2]), Boolean.Parse(line[3]));
                goals.Add(goal);
            }
            else if (line.Length == 3)
            {
                EternalGoal goal = new EternalGoal(line[0], line[1], int.Parse(line[2]));
                goals.Add(goal);
            }
            else if (line.Length == 6)
            {
                ChecklistGoal goal = new ChecklistGoal(line[0], line[1], int.Parse(line[2]), int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]));
                goals.Add(goal);
            }
        }
    }
}