using Microsoft.EntityFrameworkCore;
namespace MvcCodeFirstApproach2_ss.Models

{
    public class AppDbContext : DbContext   
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }
    }
}
