abstract class Activity
{
    protected string _date;
    protected int _length;
    protected string _type;

    public Activity(string date, int length, string type)
    {
        _date = date;
        _length = length;
        _type = type;
    }

    public abstract double Distance();

    public abstract double Speed();

    public abstract double Pace();

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_type} ({_length} min)- Distance {string.Format("{0:0.0}", Distance())} km, Speed {string.Format("{0:0.0}", Speed())} kmph, Pace: {string.Format("{0:0.0}", Pace())} min per km");
    }
}