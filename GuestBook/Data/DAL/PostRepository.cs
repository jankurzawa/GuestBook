using GuestBook.Data.DAL.Interfaces;
using GuestBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace GuestBook.Data.DAL
{
    public class PostRepository : IPostRepository
    {
        private GuestBookContext _guestBookContext;
        public PostRepository()
        {
            _guestBookContext = new GuestBookContext();
        }
        public int GetNumberOfPosts() => _guestBookContext.Posts.Count();
        public List<Post> GetPage(int numberOfPage)
        {
            var jebac = _guestBookContext.Posts.ToList();
            var chuj = jebac.OrderBy(p => p.CreateTime);
            var kupa = chuj.Take(5 * numberOfPage).TakeLast(5).ToList();
            return kupa;
        }
        public void AddNewPost(Post newPost)
        {
            _guestBookContext.Posts.Add(newPost);
            _guestBookContext.SaveChanges();
        }
    }
}
