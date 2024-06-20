using WebTest.Models.BD;

namespace WebTest.ViewModels
{
    public class ListTableModel
    {
        public List<Element> Elements { get; set; }
        public List<ColumnElementPar> ColumnElementPars { get; set; }
        public List<ColumnElementPar> ColumnElementHead { get; set; }
        public Pricelist Pricelist { get; set; }
    }
}
