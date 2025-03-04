﻿using ProductMicroservices.DBContexts;
using ProductMicroservices.Models;

namespace ProductMicroservices.Repository;

public class ProductRepository : IProductRepository
{
    private readonly ProductContext _dbContext;

    public ProductRepository(ProductContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void DeleteProduct(int productId)
    {
        var product = _dbContext.Products.Find(productId);
        _dbContext.Products.Remove(product);
        Save();
    }

    public Product GetProductById(int productId)
    {
        return _dbContext.Products.Find(productId)!;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _dbContext.Products.ToList();
    }

    public void InsertProduct(Product product)
    {
        _dbContext.Products.Add(product);
        Save();
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }

    public void UpdateProduct(Product product)
    {
        _dbContext.Products.Update(product);
        Save();
    }
}
