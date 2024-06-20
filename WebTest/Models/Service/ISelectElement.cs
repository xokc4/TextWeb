using WebTest.Models.BD;

namespace WebTest.Models.Service
{
    public interface ISelectElement
    {
        abstract static List<Element> SelectElement(int idPriceList);
    }
}
