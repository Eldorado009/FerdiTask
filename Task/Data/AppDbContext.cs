using Microsoft.EntityFrameworkCore;
using Task.Models;

namespace Task.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderImage> SliderImages { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }
        
    }
}
