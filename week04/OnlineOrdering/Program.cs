using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // CREATE FIRST CUSTOMER (USA)
        // ==========================================

        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA");

        Customer customer1 = new Customer(
            "John Smith",
            address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product(
            "Laptop", "P101", 800, 1));

        order1.AddProduct(new Product(
            "Mouse", "P102", 25, 2));

        order1.AddProduct(new Product(
            "Keyboard", "P103", 50, 1));


        // ==========================================
        // CREATE SECOND CUSTOMER (NIGERIA)
        // ==========================================

        Address address2 = new Address(
            "15 Aminu Kano Crescent",
            "Abuja",
            "FCT",
            "Nigeria");

        Customer customer2 = new Customer(
            "Martins Amorin",
            address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product(
            "Smartphone", "P201", 500, 1));

        order2.AddProduct(new Product(
            "Power Bank", "P202", 40, 2));


        // ==========================================
        // DISPLAY ORDER 1
        // ==========================================

        Console.WriteLine("=================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("=================================");

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine(
            $"Total Cost: ${order1.CalculateTotalCost()}");


        // ==========================================
        // DISPLAY ORDER 2
        // ==========================================

        Console.WriteLine("\n=================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("=================================");

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("\nPacking Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine(
            $"Total Cost: ${order2.CalculateTotalCost()}");
    }
}