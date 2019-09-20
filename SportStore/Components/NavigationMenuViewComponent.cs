using Microsoft.AspNetCore.Mvc;
using SportStore.Models;
using System.Linq;

namespace SportStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public IProductRepository Repository { get; set; }

        public NavigationMenuViewComponent(IProductRepository repo)
        {
            Repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectCategory = RouteData?.Values["category"];
            return View(Repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
