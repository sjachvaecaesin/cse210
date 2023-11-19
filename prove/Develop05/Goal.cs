abstract class Goal
{
    protected int _score;
    protected string _goal;
    protected string _description;
    protected Boolean _done;

    public Goal(string goal, string description, int score, Boolean done = false)
    {
        _score = score;
        _description = description;
        _goal = goal;
        _done = done;
    }

    public abstract string GoalToString();

    public abstract int GetBonus();

    public abstract int GetCurrent();

    public abstract int GetMilestone();

    public abstract int Complete();

    public int GetScore()
    {
        return _score;
    }

    public string GetGoal()
    {
        return _goal;
    }

    public string GetDesc()
    {
        return _description;
    }

    public Boolean GetDone()
    {
        return _done;
    }
}