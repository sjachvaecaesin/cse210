class ChecklistGoal : Goal
{
    private int _bonus;
    private int _milestone;
    private int _currentMilestone;

    public ChecklistGoal(string goal, string description, int score, int bonus, int milestone, int current = 0, Boolean done = false) : base(goal, description, score, done)
    {
        _milestone = milestone;
        _currentMilestone = current;
        _bonus = bonus;
    }

    private int Score()
    {
        int score;
        isDone();
        if (_done)
        {
            score = _score + _bonus;
        }
        else
        {
            score = _score;
        }

        return score;
    }

    public override int Complete()
    {
        isDone();
        if (_done)
        {
            return 0;
        }
        else
        {
            _currentMilestone++;
            return Score();
        }
    }

    public override string GoalToString()
    {
        isDone();
        string done;
        if (_done)
        {
            done = "X";
        }
        else
        {
            done = " ";
        }

        return $"[{done}] {_goal} ({_description}) -- Currently completed: {_currentMilestone}/{_milestone}";
    }

    private void isDone()
    {
        if (_currentMilestone == _milestone)
        {
            _done = true;
        }
    }
    
    public override int GetBonus()
    {
        return _bonus;
    }

    public override int GetCurrent()
    {
        return _currentMilestone;
    }

    public override int GetMilestone()
    {
        return _milestone;
    }
}