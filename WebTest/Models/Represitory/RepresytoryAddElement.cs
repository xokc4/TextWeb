using WebTest.Models.BD;
using WebTest.Models.Service;

namespace WebTest.Models.Represitory
{
    public class RepresytoryAddElement : IAddElement
    {
        /// <summary>
        /// метод по добавлению всей общей строки
        /// </summary>
        /// <param name="id"></param>
        /// <param name="element"></param>
        /// <param name="columnElementPar"></param>
        public static void AddElement(int id, Element element, List<ColumnElementPar> columnElementPar)
        {
            MyDbContext myDbContext = new MyDbContext();

            int IdOne = 0;
            if (myDbContext.Elements.ToList().Count!=0)
            {
                IdOne = myDbContext.Elements.Max(e => e.IdElement);
            }
             

            element.IdOne = IdOne+1;

            element.IdOnlystring= id;

            foreach(var i in columnElementPar)
            {
                i.IdOneColumn = element.IdOne;

                myDbContext.Add(i);
            }

            myDbContext.Add(element);

            myDbContext.SaveChanges();            
        }
    }
}
