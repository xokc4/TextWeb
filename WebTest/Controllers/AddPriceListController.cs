using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebTest.Models.Represitory;
using WebTest.ViewModels;

namespace WebTest.Controllers
{
    public class AddPriceListController : Controller
    {
        [HttpGet]
        public IActionResult AddPriceList()
        {
            var model = new AddPriceListModel();
            return View(model);

        }

        [HttpPost]
        public IActionResult ProcessPriceList([FromBody] AddPriceListModel model=null)
        {
            ViewController.AddPriceListViewCon.ProcessPriceListView(model);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Back()
        {
            // Перенаправление на предыдущую страницу или другую страницу
            return RedirectToAction("Index", "Home");
        }
    }
}

