using Microsoft.EntityFrameworkCore;
using PizzaPalace.Services.ProductAPI.Models;

namespace PizzaPalace.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

    }
}
