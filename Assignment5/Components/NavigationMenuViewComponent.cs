using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookstoreRepository repository;

        public NavigationMenuViewComponent(IBookstoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()    //Building info for a partial view, but need to build the actual view
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];    //whatever it is called in endpoint routing

            return View(repository.Books.
                Select(x => x.Category).
                Distinct().
                OrderBy(x => x));
        }
    }
}
