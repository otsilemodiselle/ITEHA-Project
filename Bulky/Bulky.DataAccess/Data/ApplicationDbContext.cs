using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Handcrafted Jewelry", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Locally-Produced Clothing", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Art and Home Decor", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Furniture and Homeware", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Gourmet Food and Snacks", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Health and Wellness Products", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Bespoke Accessories", DisplayOrder = 7 }
                );
        }
    }
}
