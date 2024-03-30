using System;

public class Order
{
    private Customer _customer;
    private List<Products> _products;

    public Order(Customer customer, List<Products> products)    // constructor
    {
        _customer = customer;
        _products = products;
    }

    public double TotalCost()       // calculate total cost
    {
        double totalCost = 0;
        foreach (Products product in _products)
        {
            totalCost += product.TotalPrice();
        }

        double shippingCost;
        if (_customer.IsUSA())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return totalCost + shippingCost;
    }
}