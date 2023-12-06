class Bicycle : Activity
{
    private double _speed;

    public Bicycle(string date, int length, string type, double speed) : base(date, length, type)
    {
        _speed = speed;
    }

    public override double Distance()
    {
        double distance = _speed * _length / 60;
        return distance;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60 / _speed;
    }
}