using WebTest.Models.BD;
using WebTest.ViewModels;

namespace WebTest.Models.Service
{
    public interface IAddPriceList
    {
        abstract static void AddPrice(AddPriceListModel model);
    }
}
