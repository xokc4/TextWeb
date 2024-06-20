using WebTest.Models.BD;
using WebTest.Models.Service;

namespace WebTest.Models.Represitory
{
    public class RepresitorySelect : ISelectPriceList, ISelectElement, ISelectColumnElementPar
    {
        /// <summary>
        /// метод по находждению столбцов и данных про них
        /// </summary>
        /// <param name="IdOne"></param>
        /// <returns></returns>
        public static List<ColumnElementPar> SelectColumnElementPar(int IdOne)
        {
            List<ColumnElementPar> columnElementsPar = new List<ColumnElementPar>();

            MyDbContext db = new MyDbContext();

            columnElementsPar = db.ColumnElements.Where(e => e.IdOneColumn == IdOne).ToList();

            return columnElementsPar;
        }
        /// <summary>
        /// метод по находждению столбцов 
        /// </summary>
        /// <param name="IdOne"></param>
        /// <returns></returns>
        public static List<ColumnElementPar> SelectColumnElementParHead(int IdOne)
        {
            List<ColumnElementPar> columnElementsPar = new List<ColumnElementPar>();

            MyDbContext db = new MyDbContext();

            columnElementsPar = db.ColumnElements.Where(e => e.IdOnlyString == IdOne && e.IdOneColumn==null).ToList();

            return columnElementsPar;
        }
        /// <summary>
        /// метод по находждению Таблиц
        /// </summary>
        /// <returns></returns>
        public static List<Pricelist> SelectPriceList()
        {
            List<Pricelist> pricelists = new List<Pricelist>();

            MyDbContext db = new MyDbContext();

            pricelists = db.Pricelists.ToList();


            return pricelists;
        }
        /// <summary>
        /// метод по находждению строк с главными данными
        /// </summary>
        /// <param name="idPriceList"></param>
        /// <returns></returns>
        public static List<Element> SelectElement(int idPriceList)
        {
            List<Element> elements = new List<Element>();

            MyDbContext db = new MyDbContext();

            elements = db.Elements.Where(e => e.IdOnlystring == idPriceList).ToList();

            return elements;
        }
    }
}
