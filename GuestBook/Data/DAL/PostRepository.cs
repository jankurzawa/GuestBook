using GuestBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace GuestBook.Data.DAL
{
    public static class PostRepository
    {
        private static GuestBookContext _guestBookContext = new GuestBookContext();
        public static int GetNumberOfPosts() => _guestBookContext.Posts.Count();
        public static List<Post> GetPage(int numberOfPage) 
            => _guestBookContext.Posts.ToList().OrderBy(p => p.CreateTime).Take(5*numberOfPage).TakeLast(5).ToList();
        public static void AddNewPost(Post newPost)
        {
            _guestBookContext.Posts.Add(newPost);
            _guestBookContext.SaveChanges();
        }
    }
}
