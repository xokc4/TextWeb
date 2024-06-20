using Microsoft.AspNetCore.Mvc;
using WebTest.Models.BD;
using WebTest.Models.Represitory;
using WebTest.ViewModels;

namespace WebTest.ViewController
{
    public class EditLinesViewCon
    {
        public static EditLinesModel EditlinesView(int idLines, int IdPriceList)
        {

            Pricelist pricelists = RepresitoryOne.OnePriceList(IdPriceList);
            Element element = RepresitoryOne.OneElements(idLines);
            List<ColumnElementPar> columnElementPars = RepresitorySelect.SelectColumnElementPar(element.IdOne);
            var model = new EditLinesModel
            {
                ColumnElementPars = columnElementPars,
                pricelists = pricelists,
                element = element,

            };

            return model;
        }
        public static void DeleteView(int id, int idOne)
        {
            RepresitoryDelete.DeleteElement(id);
            RepresitoryDelete.DeleteElementColumncs(idOne);

        }
        public static void ReadView(EditLinesModel model)
        {
            RepresitoryRead.ReadColumn(model.element);
            RepresitoryRead.ReadElementColumn(model.ColumnElementPars);

        }
    }
}
