﻿using Microsoft.AspNetCore.Mvc;
using Mission09.Models;
using Mission09.Models.ViewModels;
using System.Linq;

namespace Mission09.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;

        public HomeController(IBookstoreRepository br)
        {
            repo = br;
        }
        public IActionResult Index(string bookCategory, int pageNum = 1)
        {
            // set number of books to be displayed on one page
            int pageSize = 10;

            var bvm = new BooksViewModel
            {
                // query the books based on title, page number, and page size
                Books = repo.Books
                .Where(p => (p.Category == bookCategory) || (bookCategory == null))
                .OrderBy(p => p.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks =
                    (bookCategory == null
                        ? repo.Books.Count()
                        : repo.Books.Where(x => x.Category == bookCategory).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(bvm);
        }
    }
}