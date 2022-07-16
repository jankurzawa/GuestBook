using GuestBook.Data.DAL.Interfaces;
using GuestBook.Models;
using System.Collections.Generic;
using System.Linq;

namespace GuestBook.Data.DAL
{
    public class PostRepository : IPostRepository
    {
        public static int _numberOfPostOnPage = 5;
        private GuestBookContext _guestBookContext;
        public PostRepository()
        {
            _guestBookContext = new GuestBookContext();
        }
        public int GetNumberOfPages()
        {
            var numberOfPosts = _guestBookContext.Posts.Count();
            if (numberOfPosts % _numberOfPostOnPage == 0) return numberOfPosts / _numberOfPostOnPage;
            return (numberOfPosts / _numberOfPostOnPage) + 1;
        }
        public List<Post> GetPage(int numberOfPage)
        {
            var numberOfLastPosts = _guestBookContext.Posts.Count() % _numberOfPostOnPage;
            if (numberOfLastPosts != 0 && numberOfPage == GetNumberOfPages())
                return _guestBookContext.Posts.ToList().OrderByDescending(p => p.CreateTime).TakeLast(numberOfLastPosts).ToList();
            return _guestBookContext.Posts.ToList().OrderByDescending(p => p.CreateTime).Take(_numberOfPostOnPage * numberOfPage).TakeLast(_numberOfPostOnPage).ToList();
        }
        public void AddNewPost(Post newPost)
        {
            _guestBookContext.Posts.Add(newPost);
            _guestBookContext.SaveChanges();
        }
    }
}
