using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GuestBook.Data;
using GuestBook.Models;
using GuestBook.Data.DAL;

namespace GuestBook.Controllers
{
    public class PostsController : Controller
    {
        private readonly GuestBookContext _context;
        private int _numberOfPage;

        public PostsController(GuestBookContext context)
        {
            _context = context;
            _numberOfPage = 1;
        }

        // GET: Posts
        public async Task<IActionResult> Index() => View(PostRepository.GetPage(_numberOfPage));

        // GET: Posts/Index
        public async Task<IActionResult> PageUp()
        {
            if (_numberOfPage < PostRepository.GetNumberOfPosts())
                _numberOfPage++;
            return View(PostRepository.GetPage(_numberOfPage));
        }

        // GET: Posts
        public async Task<IActionResult> PageDown()
        {
            if (_numberOfPage > 1)
                _numberOfPage--;
            return RedirectToAction(nameof(Index));
        }

        // GET: Posts/Create
        public IActionResult Create() => View();

        // POST: Posts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreateTime,Name,Email,Content")] Post post)
        {
            if (ModelState.IsValid)
            {
                post.Id = Guid.NewGuid();
                PostRepository.AddNewPost(post);
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }
    }
}
