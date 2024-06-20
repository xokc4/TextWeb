using WebTest.Models.BD;
using WebTest.Models.Service;
using WebTest.ViewModels;

namespace WebTest.Models.Represitory
{/// <summary>
/// метод по добавлению PriceList а точнее таблицы также добавляются колонки
/// </summary>
    public class RepresitoryAddPriceList : IAddPriceList
    {
        public static void AddPrice(AddPriceListModel model)
        {
            MyDbContext myDbContext = new MyDbContext();

            int MaxPriceList = myDbContext.Pricelists.Max(e=>e.IdOnlystring);

            Pricelist pricelist = new Pricelist(model.ListName,MaxPriceList+1);
            foreach(var i in model.Rows)
            {
                ColumnElementPar columnElementPar = new ColumnElementPar(i.ToString(),pricelist.IdOnlystring);

                myDbContext.ColumnElements.Add(columnElementPar);
            }
            myDbContext.Pricelists.Add(pricelist);
            myDbContext.SaveChanges();
            
        }
    }
}
