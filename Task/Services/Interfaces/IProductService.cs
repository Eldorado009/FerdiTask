using Task.Models;

namespace Task.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
    }
}
