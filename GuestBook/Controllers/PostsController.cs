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
using GuestBook.Data.DAL.Interfaces;

namespace GuestBook.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostRepository _postRepository;
        private static int _numberOfPage = 1;

        public PostsController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        // GET: Posts
        public async Task<IActionResult> Index()
        {
            TempData["numberOfPage"] = _numberOfPage;
            var gowno = _postRepository.GetPage(_numberOfPage);
            return View(gowno);
        }
        // GET: Posts/Index
        public IActionResult PageUp()
        {
            if (_numberOfPage < _postRepository.GetNumberOfPosts())
                _numberOfPage++;
            return RedirectToAction("Index");
        }

        // GET: Posts
        public async Task<IActionResult> PageDown()
        {
            if (_numberOfPage > 1)
                _numberOfPage--;
            return RedirectToAction("Index");
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
                _postRepository.AddNewPost(post);
                return RedirectToAction(nameof(Index));
            }
            return View(post);
        }
    }
}
