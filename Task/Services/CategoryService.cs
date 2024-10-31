using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models;
using Task.Services.Interfaces;

namespace Task.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly AppDbContext _context;
        public CategoryService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
