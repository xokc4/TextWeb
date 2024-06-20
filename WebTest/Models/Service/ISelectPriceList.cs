using WebTest.Models.BD;

namespace WebTest.Models.Service
{
    public interface ISelectPriceList
    {
         abstract static List<Pricelist> SelectPriceList();
    }
}
