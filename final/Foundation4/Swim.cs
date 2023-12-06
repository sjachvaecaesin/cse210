class Swim : Activity
{
    private int _laps;

    public Swim(string date, int length, string type, int laps) : base(date, length, type)
    {
        _laps = laps;
    }

    public override double Distance()
    {
        double distance = _laps / 20.0;
        return distance;
    }

    public override double Speed()
    {
        double speed = Distance() / _length * 60;
        return speed;
    }

    public override double Pace()
    {
        double pace = _length / Distance();
        return pace;
    }
}