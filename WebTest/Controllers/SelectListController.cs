using Microsoft.AspNetCore.Mvc;
using WebTest.Models.BD;
using WebTest.Models.Represitory;
using WebTest.ViewController;
using WebTest.ViewModels;

namespace WebTest.Controllers
{
    public class SelectListController : Controller
    {
        public IActionResult SelectList(int id)
        {
           var model = SelectListViewCon.SelectListView(id);

            return View(model);
        }

    }
}
