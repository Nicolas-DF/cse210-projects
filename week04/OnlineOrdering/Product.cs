

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
    public string GetName()
    {
        return _name;
    }
    public int GetID()
    {
        return _id;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetPrice()
    {
        return _price;
    }
}