using Assignment5.Models;
using Assignment5.Models.View_Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookstoreRepository _repository;

        int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookstoreRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index(string category, string classification, int pageNum = 1)
        {
            return View(new BookListViewModel
            {
                Books = _repository.Books.
                            Where(p => category == null || p.Category == category).  //If category is null, then there isn't a category to filter by. But if there is a category, then we only show those in the category
                            OrderBy(p => p.BookId).
                            Skip((pageNum - 1) * PageSize).
                            Take(PageSize)
                ,

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = PageSize,
                    TotalNumItems  = category == null ? _repository.Books.Count() : _repository.Books.Where(x => x.Category == category).Count()
                    //To have the right number of pages in the pagination
                }
                ,
                CurrentCategory = category
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
