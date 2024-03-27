
using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAcess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.Entity<Category>().HasData(
             new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
             new Category { CategoryId = 2, Name = "SciFi", DisplayOrder = 2 },
             new Category { CategoryId = 3, Name = "Hostory", DisplayOrder = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product { Id = 1, Title = "Cocacola", Description = "Nuoc ngot",ISBN="jsjsjsjfnfee",Author="Viet",ListPrice=99,Price=90,Price50=85,Price100=80,CategoryId=1,ImageUrl=""},
            new Product { Id = 2, Title = "pessi", Description = "nuoc uong", ISBN = "jsjsjsjfnfee", Author = "Nam", ListPrice = 40, Price = 20, Price50 = 30, Price100 = 35 , CategoryId = 1, ImageUrl = "" },
            new Product { Id = 3, Title = "Mi", Description = "jjseeejs", ISBN = "eess", Author = "Viet", ListPrice = 99, Price = 90, Price50 = 85, Price100 = 80 , CategoryId = 1, ImageUrl = "" },
            new Product { Id = 4, Title = "Banh", Description = "fffff", ISBN = "dddff", Author = "Viet", ListPrice = 80, Price = 60, Price50 = 50, Price100 = 10, CategoryId = 2, ImageUrl = "" },
            new Product { Id = 5, Title = "Ao", Description = "ssss", ISBN = "ffff", Author = "Hanh", ListPrice = 99, Price = 90, Price50 = 85, Price100 = 80, CategoryId = 2, ImageUrl = "" },
            new Product { Id = 6, Title = "Quan", Description = "rrrs", ISBN = "wwww", Author = "Chan", ListPrice = 99, Price = 90, Price50 = 85, Price100 = 80 , CategoryId = 3, ImageUrl = "" }
           );
        }

    }
}
