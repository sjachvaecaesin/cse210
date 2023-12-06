class Reception : Event
{
    private string _email;

    public Reception(string type, string title, string description, string date, string time, Address address, string email) : base(type, title, description, date, time, address)
    {
        _email = email;
    }

    public void Full()
    {
        Standard();
        Console.WriteLine();
        Console.WriteLine($"The email for this reception is {_email}.");
    }
}