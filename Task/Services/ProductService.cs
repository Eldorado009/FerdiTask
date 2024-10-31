using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models;
using Task.Services.Interfaces;

namespace Task.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _context.Products.Include(m=>m.Category).Include(m=>m.Images).ToListAsync();
        }
    }
}
