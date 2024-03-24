using BulkyWebRazor_Temp.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BulkyWebRazor_Temp.Data
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
            new Category { CategoryId = 1, Name = "Action", DisplayOrder = 1 },
            new Category { CategoryId = 2, Name = "SciFi", DisplayOrder = 2 },
            new Category { CategoryId = 3, Name = "Hostory", DisplayOrder = 3 }
           );
        }


    }
}
