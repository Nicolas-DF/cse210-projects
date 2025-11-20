

public class Customer
{
    private string _name;
    private Address address = new Address();



    public void LivesInUSA()
    {
        if (address.IsInUSA())
        {
            Console.WriteLine("The customer lives in the USA");
        }
        else
        {
            Console.WriteLine("The costumer lives not in the USA");
        }
    }

}