using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebTest.Models.BD;
using WebTest.Models.Represitory;
using WebTest.ViewController;
using WebTest.ViewModels;

namespace WebTest.Controllers
{
    public class AddColumnController : Controller
    {
        public IActionResult AddColumn(int Id)
        {
            var model = AddColumViewCon.AddColumnView(Id);

            return View(model);
        }
        [HttpPost]
        public IActionResult AddColumnBd(int id,Element element, List<ColumnElementPar> columnElementPar)
        {
            AddColumViewCon.AddColumnBdView(id,element,columnElementPar);


            return RedirectToAction("AddColumn", "AddColumn", new { Id = id });
        }
    }
}
