

using System.Data.SqlTypes;

namespace Domain.Products;

public class Product
{

    public Product(ProductId id, string name, Money price, Sku sku)
    {
        Id = id;
        name = name;
        price = price;
        Sku = sku;
    }
    {
        
    }
    public ProductId Id { get; private set; }

    public string Name { get; private set; } = string.Empty;

    public Money Price { get; private set; }

    public Sku Sku { get; private set; }
}
