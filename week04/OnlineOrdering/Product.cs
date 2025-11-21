

using System.Data.Common;

public class Product
{
    private int _id;
    private string _name;
    private double _price;
    private int _quantity;

    public Product(string name, int id, int quantity, double price)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}