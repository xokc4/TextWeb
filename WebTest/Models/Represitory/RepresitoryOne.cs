using WebTest.Models.BD;
using WebTest.Models.Service;

namespace WebTest.Models.Represitory
{
    public class RepresitoryOne : ISelectOnePriceList, IselectOneElements
    {
        /// <summary>
        /// Метод по нахожению строки с данными названия и индекса
        /// </summary>
        /// <param name="idPriceList"></param>
        /// <returns></returns>
        public static Element OneElements(int idElement)
        {
            Element element = new Element();

            MyDbContext db = new MyDbContext();

            element = db.Elements.Where(e => e.IdElement == idElement).FirstOrDefault();

            return element;
        }

        /// <summary>
        /// Метод по нахожению PriceLista
        /// </summary>
        /// <param name="idPriceList"></param>
        /// <returns></returns>
        public static Pricelist OnePriceList(int idPriceList)
        {
            Pricelist pricelist = new Pricelist();

            MyDbContext db = new MyDbContext();

            pricelist = db.Pricelists.Where(e => e.IdOnlystring == idPriceList).FirstOrDefault();

            return pricelist;
        }
        
    }
}
