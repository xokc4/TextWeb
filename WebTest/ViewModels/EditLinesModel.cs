using WebTest.Models.BD;

namespace WebTest.ViewModels
{
    public class EditLinesModel
    {
        public List<ColumnElementPar> ColumnElementPars { get; set; }
        public Pricelist pricelists { get; set; }
        public Element element { get; set; }
    }
}
