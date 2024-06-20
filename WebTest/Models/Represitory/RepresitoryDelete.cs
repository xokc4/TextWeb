using WebTest.Models.BD;
using WebTest.Models.Service;

namespace WebTest.Models.Represitory
{
    public class RepresitoryDelete : IDeleteElement, IDeleteElementColumncs
    {
        /// <summary>
        /// метод по удалению элемента строки навзания и индекса
        /// </summary>
        /// <param name="Id"></param>
        public static void DeleteElement(int Id)
        {
            MyDbContext myDbContext = new MyDbContext();
            var element = myDbContext.Elements.FirstOrDefault(e=>e.IdElement==Id);
            myDbContext.Elements.Remove(element);
            myDbContext.SaveChanges();
        }
        /// <summary>
        /// метод по удалению элемента строки а точнее столбцов
        /// </summary>
        /// <param name="Id"></param>
        public static void DeleteElementColumncs(int Id)
        {
            MyDbContext myDbContext=new MyDbContext();
            List<ColumnElementPar> columnElementPars = Represitory.RepresitorySelect.SelectColumnElementPar(Id);
            foreach(var i in columnElementPars)
            {
                myDbContext.ColumnElements.Remove(i);
            }
            myDbContext.SaveChanges();
        }

    }
}
