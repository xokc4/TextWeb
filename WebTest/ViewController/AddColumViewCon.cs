using Microsoft.AspNetCore.Mvc;
using WebTest.Models.BD;
using WebTest.Models.Represitory;
using WebTest.ViewModels;

namespace WebTest.ViewController
{
    public class AddColumViewCon
    {
        /// <summary>
        /// создание и передачи модели для html странички 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static AddColumnModel AddColumnView(int Id)
        {
            Pricelist pricelist = RepresitoryOne.OnePriceList(Id);

            Element element = RepresitoryOne.OneElements(pricelist.IdOnlystring);


            List<ColumnElementPar> columnList = RepresitorySelect.SelectColumnElementParHead(Id);

            var model = new AddColumnModel
            {
                pricelists = pricelist,
                ColumnElementPars = columnList
            };
            return model;
        }
        /// <summary>
        /// добавления строки в бд
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public static void AddColumnBdView(int id, Element element, List<ColumnElementPar> columnElementPar)
        {
            RepresytoryAddElement.AddElement(id, element, columnElementPar);
        }
    }
}
