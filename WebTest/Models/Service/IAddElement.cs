using WebTest.Models.BD;

namespace WebTest.Models.Service
{
    public interface IAddElement
    {
         abstract static void AddElement(int id, Element element, List<ColumnElementPar> columnElementPar);
    }
}
