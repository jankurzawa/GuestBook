using Microsoft.EntityFrameworkCore;
using GuestBook.Models;
using GuestBook.Data.Seeders;

namespace GuestBook.Data
{
    public class GuestBookContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=GuestBook;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.SeedDataBase();
        }
    }
}