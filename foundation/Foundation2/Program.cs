using System;

class Program
{
    static void Main(string[] args)
    {
        // Create products
        Product product1 = new Product("Laptop", "P001", 1200.50m, 1);
        Product product2 = new Product("Mouse", "P002", 25.75m, 2);
        Product product3 = new Product("Keyboard", "P003", 75.00m, 1);

        Product product4 = new Product("Snickers Canvas", "P004", 800.00m, 1);
        Product product5 = new Product("Channel Handbag", "P005", 20.00m, 3);

        // Create addresses
        Address address1 = new Address("123 Elm Street", "Springfield", "IL", "USA");
        Address address2 = new Address("756 Garki Town", "Abuja", "ON", "NIGERIA");

        // Create customers
        Customer customer1 = new Customer("Andrew Parkinson", address1);
        Customer customer2 = new Customer("Ebubechi Anya", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Store orders in a list
        List<Order> orders = new List<Order> { order1, order2 };

        // Display details for each order
        foreach (Order order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}

class Product
{
    private string Name;
    private string ProductId;
    private decimal Price;
    private int Quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }

    public string GetProductDetails()
    {
        return $"{Name} (ID: {ProductId})";
    }
}

class Address
{
    private string Street;
    private string City;
    private string StateOrProvince;
    private string Country;

    public Address(string street, string city, string stateOrProvince, string country)
    {
        Street = street;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {StateOrProvince}\n{Country}";
    }
}

class Customer
{
    private string Name;
    private Address Address;

    public Customer(string name, Address address)
    {
        Name = name;
        Address = address;
    }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }

    public string GetCustomerDetails()
    {
        return $"{Name}\n{Address.GetFullAddress()}";
    }
}

class Order
{
    private List<Product> Products;
    private Customer Customer;

    public Order(Customer customer)
    {
        Customer = customer;
        Products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in Products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        totalCost += Customer.IsInUSA() ? 5 : 35;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in Products)
        {
            label += product.GetProductDetails() + "\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return Customer.GetCustomerDetails();
    }
}