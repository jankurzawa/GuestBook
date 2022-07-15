using System;
using System.ComponentModel.DataAnnotations;

namespace GuestBook.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public DateTime CreateTime { get; set; }
        [Required]
        [RegularExpression(@"(.|\s)*\S(.|\s)*", 
            ErrorMessage = "You can't use only white spaces")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",
            ErrorMessage = "Your e-mail is not correct.")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"(.|\s)*\S(.|\s)*",
            ErrorMessage = "You can't use only white spaces")]
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
