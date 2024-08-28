using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Handcrafted Jewelry", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Locally-Produced Clothing", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Art and Home Decor", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Furniture and Homeware", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Gourmet Food and Snacks", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Health and Wellness Products", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Bespoke Accessories", DisplayOrder = 7 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Painting",
                    Supplier = "Arckerman Artworks",
                    Description = "Paiting of African woman.",
                    Barcode = "827349",
                    ListPrice = 1999,
                    CategoryId = 3,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 2,
                    Name = "Ornament",
                    Supplier = "Chokwe Carvings",
                    Description = "Sculpture of African woman.",
                    Barcode = "193674",
                    ListPrice = 849,
                    CategoryId = 3,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 3,
                    Name = "Masks",
                    Supplier = "Ettiene Etchings",
                    Description = "A trio of African style mask statues.",
                    Barcode = "582913",
                    ListPrice = 2500,
                    CategoryId = 3,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 4,
                    Name = "Necklace",
                    Supplier = "Nandi Necklaces",
                    Description = "Crescent shaped necklace.",
                    Barcode = "746025",
                    ListPrice = 475,
                    CategoryId = 1,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 5,
                    Name = "Bracelet",
                    Supplier = "Barend Beadwork",
                    Description = "Ornate beaded bracelet.",
                    Barcode = "238964",
                    ListPrice = 399,
                    CategoryId = 1,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 6,
                    Name = "Charmed Necklace",
                    Supplier = "Japhthah Jewellers",
                    Description = "Beaded necklace with intricate charm.",
                    Barcode = "901758",
                    ListPrice = 819,
                    CategoryId = 1,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 7,
                    Name = "Stool and Vase",
                    Supplier = "Francis Furnishers",
                    Description = "Wooden stool with African pot atop.",
                    Barcode = "364217",
                    ListPrice = 1000,
                    CategoryId = 4,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 8,
                    Name = "Showcase",
                    Supplier = "Author Artisans",
                    Description = "Cabinet with bespoke pottery on display.",
                    Barcode = "512480",
                    ListPrice = 4899,
                    CategoryId = 4,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 9,
                    Name = "Couch",
                    Supplier = "Makhubela Makers",
                    Description = "Sleek couch with African style fabric.",
                    Barcode = "679341",
                    ListPrice = 3500,
                    CategoryId = 4,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 10,
                    Name = "Suit",
                    Supplier = "Thuso Taylors",
                    Description = "African style blazer and pants suit.",
                    Barcode = "453829",
                    ListPrice = 2250,
                    CategoryId = 2,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 11,
                    Name = "Gown",
                    Supplier = "Emma Embroiders",
                    Description = "African style gown for girls.",
                    Barcode = "720496",
                    ListPrice = 1600,
                    CategoryId = 2,
                    ImageUrl = ""
                },

                new Product
                {
                    Id = 12,
                    Name = "Dress",
                    Supplier = "Felicia Fashioners",
                    Description = "Bespoke cascading Africa dress.",
                    Barcode = "185237",
                    ListPrice = 2900,
                    CategoryId = 2,
                    ImageUrl = ""
                }
            );
        }
    }
}
