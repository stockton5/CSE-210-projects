using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Boise", "ID", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "M404", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine("----------------------------------------");

        
        Address address2 = new Address("456 Sunset Blvd", "Vancouver", "BC", "Canada");
        Customer customer2 = new Customer("Emily Carter", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "H900", 149.99, 1));
        order2.AddProduct(new Product("USB Cable", "U222", 9.99, 3));
        order2.AddProduct(new Product("Microphone", "MIC88", 89.95, 1));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}