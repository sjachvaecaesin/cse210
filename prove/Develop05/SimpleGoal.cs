class SimpleGoal : Goal
{
    public SimpleGoal(string goal, string description, int score, Boolean done = false) : base(goal, description, score, done){}

    public override int GetBonus()
    {
        throw new NotImplementedException();
    }

    public override int GetCurrent()
    {
        throw new NotImplementedException();
    }

    public override int GetMilestone()
    {
        throw new NotImplementedException();
    }

    public override int Complete()
    {
        if (_done)
        {
            return 0;
        }
        else
        {
            _done = true;
            return _score;
        }
    }

    public override string GoalToString()
    {
        string isDone;
        if (_done)
        {
            isDone = "X";
        }
        else
        {
            isDone = " ";
        }

        return $"[{isDone}] {_goal} ({_description})";
    }
}