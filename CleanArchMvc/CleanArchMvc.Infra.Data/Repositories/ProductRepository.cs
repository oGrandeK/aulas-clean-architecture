using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interface;
using CleanArchMvc.Infra.Data.Context;

namespace CleanArchMvc.Infra.Data.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;
    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Product> CreateAsync(Product Product)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetByIdAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> GetProductCategoryAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<Product> RemoveAsync(Product Product)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> UpdateAsync(Product Product)
    {
        throw new NotImplementedException();
    }
}