using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interface;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetByIdAsync(int? id);
    Task<Product> GetProductCategoryAsync(int? id);

    Task<Product> CreateAsync(Product Product);
    Task<Product> UpdateAsync(Product Product);
    Task<Product> RemoveAsync(Product Product);
}