class Gathering : Event
{
    private string _weather;

    public Gathering(string type, string title, string description, string date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _weather = weather;
    }

    public void Full()
    {
        Standard();
        Console.WriteLine();
        Console.WriteLine($"The weather for the gathering is {_weather}.");
    }
}