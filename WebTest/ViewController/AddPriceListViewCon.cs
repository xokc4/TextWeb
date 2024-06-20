using Microsoft.AspNetCore.Mvc;
using WebTest.Models.Represitory;
using WebTest.ViewModels;

namespace WebTest.ViewController
{
    public class AddPriceListViewCon
    {
        /// <summary>
        /// добавление priceList 
        /// </summary>
        /// <param name="model"></param>
        public static void ProcessPriceListView([FromBody] AddPriceListModel model = null)
        {
            RepresitoryAddPriceList.AddPrice(model);

        }
    }
}
