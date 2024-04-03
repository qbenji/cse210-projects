using System;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address a1 = new Address("525 S Center St", "Rexburg", "ID", "USA");
        Address a2 = new Address("859 S Yellowstone Hwy #1002", "Rexburg", "ID", "USA");
        Address a3 = new Address("S 2nd W & 3rd W", "Rexburg", "ID", "USA");

        // Events
        Event lecture = new Lecture("Programming with Classes", "Come sling code with Brother Thayne", DateTime.Now, new TimeSpan(16, 0, 0), a1, "Lecture", "Brother Thayne",48);
        Event reception = new Reception("Ben and John's Reception", "Pride month is our favorite month", DateTime.Now, new TimeSpan(18, 0, 0), a2, "Reception","BeJo@gmail.com");
        Event outdoorGathering = new OutdoorGathering("Soccer", "It's the best sport", DateTime.Now, new TimeSpan(18, 0, 0), a3, "Outdoor Gathering", 76, "Sunny", 40, 2, 1);
        
    }
}