class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, int capacity) : base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void Full()
    {
        Standard();
        Console.WriteLine();
        Console.WriteLine($"The speaker for the lecture is {_speaker}, with a capacity of {_capacity}.");
    }
}