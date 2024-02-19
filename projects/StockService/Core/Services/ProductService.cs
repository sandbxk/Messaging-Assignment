using Repository;
using StockService.Core.Entities;

namespace StockService.Core.Services;

public class ProductService
{
    private readonly IRepository<Product> _repository;
    
    public ProductService(IRepository<Product> repository)
    {
        _repository = repository;
    }
    
    public void PopulateDb()
    {
        // Populate the database with some products
        _repository.Add(new Product(-1, "A"));
        _repository.Add(new Product(-1, "B"));
        _repository.Add(new Product(-1, "C"));

    }
    
    public IEnumerable<Product> GetOrderProducts(int[] productIds)
    {
        IEnumerable<Product> result = _repository.GetAll()
            .Where(product => productIds.Contains(product.ProductID));
        return result;
    }
    
    public IEnumerable<Product> GetProducts()
    {
        return _repository.GetAll();
    }
}