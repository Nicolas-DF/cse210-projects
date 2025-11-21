using System;

class Program
{
    static void Main(string[] args)
    {
        //Addresses
        Address address1 = new Address("742 Evergreen Ridge Lane", "Springfield", "Ohio", "Usa");
        Address address2 = new Address("126 Maplecrest Hollow Road", "Calgary", "Alberta", "Canada");

        //Customers
        Customer customer1 = new Customer("Matt Murdock", address1);
        Customer customer2 = new Customer("James Howlet", address2);
        
        //Products
        Product earphone = new Product("headphone", 123, 4, 32.26);
        Product mouse = new Product("mouse", 122, 6, 17.21);
        Product keyboard = new Product("keyboard", 133, 2, 34.03);
        Product laptop = new Product("laptop", 231, 1, 2997.73);
        Product monitor = new Product("monitor", 213, 2, 231.73);

        //Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(earphone);
        order1.AddProduct(mouse);
        order1.AddProduct(keyboard);
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total cost: {order1.GetTotalPrice()}\n\n");

        Order order2 = new Order(customer2);
        order2.AddProduct(laptop);
        order2.AddProduct(monitor);
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total cost: {order2.GetTotalPrice()}");
    }
}