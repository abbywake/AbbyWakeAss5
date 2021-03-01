using AbbyWakeAss5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAss5.Components
{
    public class NavigationMenuViewComponent: ViewComponent
    {
        private IBookRepository repository;

        public NavigationMenuViewComponent(IBookRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            //get the type from the route data - what we are using for the url header
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
