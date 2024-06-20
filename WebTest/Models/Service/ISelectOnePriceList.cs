using WebTest.Models.BD;

namespace WebTest.Models.Service
{
    public interface ISelectOnePriceList
    {
        abstract static Pricelist OnePriceList(int idPriceList);
    }
}
