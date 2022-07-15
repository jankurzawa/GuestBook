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
using Microsoft.AspNetCore.Html;

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
            TempData["maxPages"] = _postRepository.GetNumberOfPages();
            return View(_postRepository.GetPage(_numberOfPage));
        }
        // GET: Posts/Index
        public IActionResult PageUp()
        {
            if (_numberOfPage < _postRepository.GetNumberOfPages())
                _numberOfPage++;
            return RedirectToAction("Index");
        }

        // GET: Posts
        public IActionResult PageDown()
        {
            if (_numberOfPage > 1)
                _numberOfPage--;
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult ChangePageFromInputLabel(string inputValue)
        {
            try
            {
                int newPage = int.Parse(inputValue);
                if (newPage >= 1 && newPage <= _postRepository.GetNumberOfPages())
                    _numberOfPage = newPage;
            }
            catch (Exception)
            {

            }
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
        public IActionResult SetNumberOfPostFromInput(string numberOfPages)
        {
            PostRepository._numberOfPostOnPage = int.Parse(numberOfPages);
            return RedirectToAction("Index");
        }
    }
}
