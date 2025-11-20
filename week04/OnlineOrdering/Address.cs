using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateORprovince;
    private string _country;

    // constructor(s)

    public bool IsInUSA()
    {
        if (_country == "USA" || _country == "US" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void GetAddress()
    {
        Console.WriteLine($"{_streetAddress}, {_city} – {_stateORprovince}, {_country}"); 
    }

}
