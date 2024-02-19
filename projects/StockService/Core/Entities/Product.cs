namespace StockService.Core.Entities;

public class Product
{
    public Product(int productId, string name)
    {
        ProductID = productId;
        Name = name;
    }

    public int ProductID { get; set; }
    public string Name { get; set; }
}