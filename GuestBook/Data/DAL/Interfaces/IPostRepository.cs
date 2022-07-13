using GuestBook.Models;
using System.Collections.Generic;

namespace GuestBook.Data.DAL.Interfaces
{
    public interface IPostRepository
    {
        public int GetNumberOfPosts();
        public List<Post> GetPage(int numberOfPage);
        public void AddNewPost(Post newPost);
    }
}
