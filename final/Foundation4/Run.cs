class Run : Activity
{
    private double _distance;

    public Run(string date, int length, string type, double distance) : base(date, length, type)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        double speed = _distance / _length * 60;
        return speed;
    }

    public override double Pace()
    {
        return _length / _distance;
    }
}