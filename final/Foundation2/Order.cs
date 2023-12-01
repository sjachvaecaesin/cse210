class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(List<Product> products, Customer customer)
    {
        _customer = customer;
        _products = products;
    }

    public double Total()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.Cost();
        }
        if (_customer.isUS())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public void Packing()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine(product.GetItem());
        }
    }

    public void Shipping()
    {
        Console.WriteLine(_customer.GetCustomer());
    }
}