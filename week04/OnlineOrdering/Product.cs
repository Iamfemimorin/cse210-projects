public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculates total cost of this product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Returns product details for packing label
    public string GetPackingInfo()
    {
        return $"Product: {_name} | ID: {_productId}";
    }
}