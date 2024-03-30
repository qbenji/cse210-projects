using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)       // constructor
    {
        _name = name;
        _address = address;
    }

    public bool IsUSA()                                 // check if country is USA
    {
        return _address.IsUSA();
    }

    public string GetName()                             // get name
    {
        return _name;
    }

    public Address GetAddress()                         // get address
    {
        return _address;
    }

    public void SetName(string name)                    // set name
    {
        _name = name;
    }

    public void SetAddress(Address address)             // set address
    {
        _address = address;
    }
}