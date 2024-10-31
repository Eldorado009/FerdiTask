using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models;
using Task.Services.Interfaces;

namespace Task.Services
{
    public class SliderImageService : ISliderImageService
    {
        private readonly AppDbContext _context;
        public SliderImageService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<SliderImage>> GetAllAsync()
        {
            return await _context.SliderImages.ToListAsync();
        }
    }
}
