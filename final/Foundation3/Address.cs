using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)    // constructor
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string SerializeAddress()                // serialize address
    {
        return $"{_street}\n{_city}, {_state}, {_country}";
    }

    public string GetStreet()                       // get street
    {
        return _street;
    }

    public string GetCity()                         // get city
    {
        return _city;
    }

    public string GetState()                        // get state
    {
        return _state;
    }

    public string GetCountry()                      // get country
    {
        return _country;
    }

    public void SetStreet(string street)            // set street
    {
        _street = street;
    }

    public void SetCity(string city)                // set city
    {
        _city = city;
    }

    public void SetState(string state)              // set state
    {
        _state = state;
    }

    public void SetCountry(string country)          // set country
    {
        _country = country;
    }

}