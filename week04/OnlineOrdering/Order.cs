

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackingLabel()
    {
        string label = "Packing Label\n";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} – (ID: {p.GetID()})\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping label:\n{_customer.GetName()}\n{_customer.GetCustomerAddress()}\n";
    }
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }
        if (_customer.LivesInUSA())
            return total += 5;
        else
            return total += 35;
    }
}