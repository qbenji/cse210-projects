using System;
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Products
{
    private string _name;
    private string _productID;
    private double _unitPrice;
    private int _quantity;
    public Products(string name, string productID, double unitPrice, int quantity)      // constructor
    {
        _name = name;
        _productID = productID;
        _unitPrice = unitPrice;
        _quantity = quantity;
    }

    public double TotalPrice()                          // calculate total price
    {
        return _unitPrice * _quantity;
    }

    public string GetName()                             // get name
    {
        return _name;
    }

    public string GetProductID()                        // get product ID
    {
        return _productID;
    }

    public double GetUnitPrice()                        // get unit price
    {
        return _unitPrice;
    }

    public int GetQuantity()                            // get quantity
    {
        return _quantity;
    }

    public void SetName(string name)                    // set name
    {
        _name = name;
    }

    public void SetProductID(string productID)          // set product ID
    {
        _productID = productID;
    }

    public void SetUnitPrice(double unitPrice)          // set unit price
    {
        _unitPrice = unitPrice;
    }

    public void SetQuantity(int quantity)               // set quantity
    {
        _quantity = quantity;
    }
}