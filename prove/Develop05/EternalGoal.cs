class EternalGoal : Goal
{
    public EternalGoal(string goal, string description, int score) : base(goal, description, score){}

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
        return _score;
    }

    public override string GoalToString()
    {
        return $"[ ] {_goal} ({_description})";
    }
}