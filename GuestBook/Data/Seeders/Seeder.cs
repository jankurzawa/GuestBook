using GuestBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace GuestBook.Data.Seeders
{
    public static class Seeder
    {
        public static void SeedDataBase(this ModelBuilder modelBulider)
        {
            List<Post> posts = new List<Post>()
            {
                new Post("Mariusz", "mariusz@gmail.com", "I was here1"),
                new Post("Marian", "mariusz@gmail.com", "I was here2"),
                new Post("Maria", "mariusz@gmail.com", "I was here3"),
                new Post("Mateusz", "mariusz@gmail.com", "I was here4"),
                new Post("Michal", "mariusz@gmail.com", "I was here5"),
                new Post("Milosz", "mariusz@gmail.com", "I was here6"),
                new Post("Marzena", "mariusz@gmail.com", "I was here7"),
                new Post("Milena", "mariusz@gmail.com", "I was here8"),
                new Post("Marlena", "mariusz@gmail.com", "I was here9"),
                new Post("Marek", "mariusz@gmail.com", "I was here10"),
            };

            modelBulider.Entity<Post>()
                .HasData(posts);
        }
    }
}
