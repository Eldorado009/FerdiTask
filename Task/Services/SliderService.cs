using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models;
using Task.Services.Interfaces;

namespace Task.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Slider> GetAsync()
        {
            return await _context.Sliders.FirstOrDefaultAsync(x => x.Id == 1);
        }
    }
}
