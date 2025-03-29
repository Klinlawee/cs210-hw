// OnlineOrdering Project
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // Create Addresses
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        
        // Create Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);
        
        // Create Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B456", 25.99, 2));
        
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "C789", 199.99, 1));
        order2.AddProduct(new Product("Keyboard", "D012", 49.99, 1));
        
        // Display Order Details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCost());
        
        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCost());
    }
}
