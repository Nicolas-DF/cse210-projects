

public class Product
{
    private int _id;
    private string _name;
    private double _price;
    private int _quantity;




    public double GetTotalCost()
    {
        return _price * _quantity;
    }
}