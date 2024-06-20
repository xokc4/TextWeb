using Microsoft.AspNetCore.Mvc;
using WebTest.Models.BD;
using WebTest.Models.Represitory;
using WebTest.ViewModels;

namespace WebTest.ViewController
{
    public class SelectListViewCon
    {
        /// <summary>
        /// Создание модели для контректной таблицы на страничке html
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static ListTableModel SelectListView(int id)
        {
            List<Element> Listelement = RepresitorySelect.SelectElement(id);

            List<ColumnElementPar> ListColumns = new List<ColumnElementPar>();
            List<ColumnElementPar> ColumnHead = RepresitorySelect.SelectColumnElementParHead(id);
            foreach (Element element in Listelement)
            {
                List<ColumnElementPar> Column = RepresitorySelect.SelectColumnElementPar(element.IdOne);

                ListColumns.AddRange(Column);
            }

            Pricelist pricelist = RepresitoryOne.OnePriceList(id);

            var model = new ListTableModel
            {
                Elements = Listelement,
                ColumnElementPars = ListColumns,
                ColumnElementHead = ColumnHead,
                Pricelist = pricelist
            };

            return model;
        }
    }
}
