class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public Boolean isUS()
    {
        if (_address.GetCountry().ToLower() == "usa")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetCustomer()
    {
        return $"Customer: {_name}\n{_address.toString()}";
    }
}