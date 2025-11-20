using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateORprovince;
    private string _country;

    public Address(string streetAddress, string city, string stateORprovince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateORprovince = stateORprovince;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Trim().ToUpper() == "USA";
    }
    public void GetAddress()
    {
        Console.WriteLine($"{_streetAddress}\n{_city}, {_stateORprovince}\n{_country}"); 
    }

}
