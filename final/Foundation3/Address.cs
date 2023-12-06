class Address
{
    private string _street;
    private string _city;
    private string _area;
    private string _country;

    public Address(string street, string city, string area, string country)
    {
        _street = street;
        _city = city;
        _area = area;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string toString()
    {
        return $"Country: {_country}\nArea: {_area}\nCity and Street: {_city}, {_street}";
    }
}