using System;
using System.Collections.Generic;

public class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public double GetTotalCost()
    {
        return price * quantity;
    }

    public string GetName() { return name; }
    public int GetProductId() { return productId; }
}

public class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{street}\n{city}, {state}\n{country}";
    }
}

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string GetName() { return name; }

    public bool IsFromUSA()
    {
        return address.IsInUSA();
    }

    public Address GetAddress() { return address; }
}

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = customer.IsFromUSA() ? 5.0 : 35.0;
        totalCost += shippingCost;

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"Product Name: {product.GetName()}, Product ID: {product.GetProductId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Product product1 = new Product("Laptop", 101, 1000.0, 1);
        Product product2 = new Product("Phone", 102, 500.0, 2);

        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Rd", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alice", address1);
        Customer customer2 = new Customer("Bob", address2);

        List<Product> productsForOrder1 = new List<Product> { product1, product2 };
        Order order1 = new Order(productsForOrder1, customer1);

        List<Product> productsForOrder2 = new List<Product> { product2 };
        Order order2 = new Order(productsForOrder2, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order1.GetTotalCost():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order2.GetTotalCost():0.00}\n");
    }
}
