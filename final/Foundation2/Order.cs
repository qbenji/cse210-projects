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

    public double TotalCost()                                   // calculate total cost
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

    public string PackingLabel()                                // get packing label
    {
        string label = "";
        foreach (Products product in _products)
        {
            label += $"{product.GetName()}, ID: {product.GetProductID()}\n";
        }
        return label;
    }

    public string ShippingLabel()                               // get shipping label
    {
        return $"Customer Name: {_customer.GetName()}\n{_customer.GetAddress().SerializeAddress()}";
    }

    public Customer GetCustomer()                               // get customer
    {
        return _customer;
    }

    public List<Products> GetProducts()                         // get products
    {
        return _products;
    }

    public void SetCustomer(Customer customer)                  // set customer
    {
        _customer = customer;
    }

    public void SetProductList(List<Products> products)         // set products
    {
        _products = products;
    }
    
}