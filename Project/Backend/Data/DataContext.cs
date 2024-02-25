using Backend.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "Abdullah" },
            new User { Id = 2, Name = "Atiq" },
            new User { Id = 3, Name = "Azizul" },
            new User { Id = 4, Name = "Iftekhar" },
            new User { Id = 5, Name = "Jonayed" }
        );
    }
}
