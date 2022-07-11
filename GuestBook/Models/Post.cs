using System;

namespace GuestBook.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public DateTime CreateTime { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }

        public Post()
        {
            Id = Guid.NewGuid();
            CreateTime = DateTime.Now;
        }
        public Post(string name, string email, string content)
        {
            Id= Guid.NewGuid();
            CreateTime= DateTime.Now;
            Name= name;
            Email= email;
            Content= content;
        }
    }
}
