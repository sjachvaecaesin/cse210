using System.ComponentModel;
using System.Net.Sockets;

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    protected Event(string type, string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }

    public void Standard()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine(_address.toString());
    }

    public void Short()
    {
        Console.WriteLine($"{_type} event");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}