

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public void LivesInUSA()
    {
        if (_address.IsInUSA())
        {
            Console.WriteLine("The customer lives in the USA");
        }
        else
        {
            Console.WriteLine("The costumer lives not in the USA");
        }
    }
    public string GetName()
    {
        return _name;
    }
    public void GetCustomerAddress()
    {
        _address.GetAddress();
    }
}