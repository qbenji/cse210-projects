using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("525 S Center St", "Rexburg", "ID", "USA");
        Customer c1 = new Customer("Ben Quiñones", a1);

        List<Products> p1 = new List<Products>();
        p1.Add(new Products("Trash Can", "T01", 19.99, 1));
        p1.Add(new Products("Trash Bag", "B09", 7.99, 1));

        Order o1 = new Order(c1, p1);
        Console.Clear();
        Console.WriteLine("Order 1 Summary...\n");
        Console.WriteLine(o1.PackingLabel());
        Console.WriteLine(o1.ShippingLabel());

        Console.WriteLine("\nTotal Cost: $" + o1.TotalCost());
    }
}