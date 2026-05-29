using System.Text;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Adds a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates order total including shipping
    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Shipping cost
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Creates packing label
    public string GetPackingLabel()
    {
        StringBuilder label = new StringBuilder();

        foreach (Product product in _products)
        {
            label.AppendLine(product.GetPackingInfo());
        }

        return label.ToString();
    }

    // Creates shipping label
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}