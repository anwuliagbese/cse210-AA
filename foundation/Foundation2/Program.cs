using System;

class Program
{
    static void Main()
    {
        // Create products for the first order
        Product product1 = new Product("Laptop", "P001", 1200.50m, 1);
        Product product2 = new Product("Mouse", "P002", 25.75m, 2);

        // Create products for the second order
        Product product3 = new Product("Shoe", "P003", 800.00m, 1);
        Product product4 = new Product("Handbag", "P004", 20.00m, 3);

        // Create addresses
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Address address2 = new Address("756 Garki Cresent", "Abuja", "ON", "Nigeria");

        // Create customers
        Customer customer1 = new Customer("Andrew Slyvester", address1);
        Customer customer2 = new Customer("Ebubechi Anya", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Display details for the first order
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

        // Display details for the second order
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}\n");
    }
}
