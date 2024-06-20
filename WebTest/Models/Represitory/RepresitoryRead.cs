using WebTest.Models.BD;
using WebTest.Models.Service;

namespace WebTest.Models.Represitory
{
    public class RepresitoryRead : IReadColumn, IReadElementColumn
    {
        /// <summary>
        /// метод по редактирования строк названия и индекса
        /// </summary>
        /// <param name="element"></param>
        public static void ReadColumn(Element element)
        {
            using (var db = new MyDbContext())
            {
                var update = db.Elements.Find(element.IdElement);
                    update.NameProduct = element.NameProduct;
                    update.IndexProduct = element.IndexProduct;
                    db.SaveChanges();
            }
        }
        /// <summary>
        /// метод по редактированию столбцов
        /// </summary>
        /// <param name="columnElementPars"></param>
        public static void ReadElementColumn(List<ColumnElementPar>  columnElementPars)
        {
            using (var db = new MyDbContext())
            {
                foreach (var columnElementPar in columnElementPars)
                {
                    // Находим элемент в базе данных по его идентификатору
                    var update = db.ColumnElements.Find(columnElementPar.IdColumn);
                        update.ContentColumn = columnElementPar.ContentColumn;

                }
                // Сохраняем изменения в базе данных
                db.SaveChanges();
            }
        }
    }
}
