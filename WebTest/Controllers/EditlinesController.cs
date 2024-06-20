using Microsoft.AspNetCore.Mvc;
using WebTest.Models.BD;
using WebTest.Models.Represitory;
using WebTest.Models.Service;
using WebTest.ViewController;
using WebTest.ViewModels;

namespace WebTest.Controllers
{
    public class EditlinesController : Controller
    {
        public IActionResult Editlines(int idLines, int IdPriceList)
        {

            var model = EditLinesViewCon.EditlinesView(idLines, IdPriceList);

            return View(model);
        }
        public IActionResult Delete(int id, int idOne)
        {
            EditLinesViewCon.DeleteView(id,idOne);
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Read(EditLinesModel model)
        {
            EditLinesViewCon.ReadView(model);


            return RedirectToAction("Index", "Home"); // Предполагается, что у вас есть представление для отображения данных
        }
    }
}
