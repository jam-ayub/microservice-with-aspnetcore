using ProductMicroservices.Models;

namespace ProductMicroservices.Repository;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
    Product GetProductById(int pruductId);
    void InsertProduct(Product product);
    void DeleteProduct(int productId);
    void UpdateProduct(Product product);
    void Save();
}
