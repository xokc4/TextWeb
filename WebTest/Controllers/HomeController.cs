using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebTest.Models;
using WebTest.Models.BD;
using WebTest.Models.Represitory;

namespace WebTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Pricelist> pricelists = RepresitorySelect.SelectPriceList();

            return View(pricelists);
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
