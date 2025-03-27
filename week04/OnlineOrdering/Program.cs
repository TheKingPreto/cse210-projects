using System;
using System.Collections.Generic;

public class Address
{
    private string street;
    private string city;
    private string stateOrProvince;
    private string country;

    // Constructor to initialize address fields
    public Address(string street, string city, string stateOrProvince, string country)
    {
        this.street = street;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    // Method to check if the address is in the USA
    public bool IsInUSA()
    {
        return country.ToLower() == "usa";
    }

    // Method to return the full address as a string
    public string GetFullAddress()
    {
        return $"{street}\n{city}, {stateOrProvince}\n{country}";
    }
}

public class Product
{
    private string name;
    private int productId;
    private decimal price;
    private int quantity;

    // Constructor to initialize product fields
    public Product(string name, int productId, decimal price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    // Method to calculate the total cost of this product (price * quantity)
    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    // Getters for product properties
    public string GetName() => name;
    public int GetProductId() => productId;
    public decimal GetPrice() => price;
    public int GetQuantity() => quantity;
}

public class Customer
{
    private string name;
    private Address address;

    // Constructor to initialize customer name and address
    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    // Method to check if the customer lives in the USA
    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    // Method to get the name of the customer
    public string GetName() => name;

    // Method to get the address of the customer
    public Address GetAddress() => address;
}

public class Order
{
    private List<Product> products;
    private Customer customer;

    // Constructor to initialize products and customer
    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Method to calculate the total cost of the order (sum of all product costs + shipping)
    public decimal GetTotalCost()
    {
        decimal totalCost = 0;

        // Add up the cost of all products
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost based on the customer's location
        decimal shippingCost = customer.IsInUSA() ? 5 : 35;
        totalCost += shippingCost;

        return totalCost;
    }

    // Method to generate the packing label (name and product ID of each product)
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    // Method to generate the shipping label (customer name and address)
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress().GetFullAddress()}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        // Create products
        Product product1 = new Product("Laptop", 101, 999.99m, 1);
        Product product2 = new Product("Phone", 102, 499.99m, 2);
        Product product3 = new Product("Headphones", 103, 79.99m, 3);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details for order1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}\n");

        // Display order details for order2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}
