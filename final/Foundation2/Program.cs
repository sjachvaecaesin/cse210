using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("Ring Road", "Clarksville", "40121", "USA");
        Customer customer1 = new Customer("Tyler Jerry", address1);

        List<Product> products = new List<Product>();
        Product product1 = new Product("Industrial Rope", 43582, 8.99, 2);
        products.Add(product1);
        product1 = new Product("Bubble gum", 34815, .75, 1);
        products.Add(product1);
        product1 = new Product("Mechanical Pencil", 78324, 1.99, 5);
        products.Add(product1);

        Order order1 = new Order(products, customer1);
        orders.Add(order1);

        address1 = new Address("Desputacion", "Rota", "87354", "Spain");
        customer1 = new Customer("Kristin Beckett", address1);

        products = new List<Product>();
        product1 = new Product("Sunflower seeds", 65724, 4.99, 3);
        products.Add(product1);
        product1 = new Product("DVD", 75428, 20.99, 1);
        products.Add(product1);
        product1 = new Product("Marshmallows", 98724, 5.99, 4);
        products.Add(product1);

        Order order2 = new Order(products, customer1);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine();
            order.Packing();
            Console.WriteLine();
            order.Shipping();
            Console.WriteLine();
            Console.WriteLine($"The total is: ${order.Total()}");
            Console.WriteLine();
        }
    }
}