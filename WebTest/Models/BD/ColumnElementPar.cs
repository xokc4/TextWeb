using System.ComponentModel.DataAnnotations;

namespace WebTest.Models.BD
{
    public class ColumnElementPar
    {
        public ColumnElementPar()
        {
        }

        public ColumnElementPar(int idOneColumn, string nameColumn, string contentColumn)
        {
            IdOneColumn= idOneColumn;
            NameColumn = nameColumn;
            ContentColumn = contentColumn;
        }

        public ColumnElementPar(string nameColumn, int idOnlyString)
        {
            NameColumn = nameColumn;
            IdOnlyString = idOnlyString;
        }

        public ColumnElementPar(int idOneColumn, string nameColumn, string contentColumn, int idcolumn) : this(idOneColumn, nameColumn, contentColumn)
        {
            IdOnlyString = idcolumn;
        }

        [Key]
        public int IdColumn { get; set; }
        public int? IdOneColumn { get; set; }
        public string NameColumn { get; set; }
        public string? ContentColumn { get; set; }
        public int IdOnlyString { get; set; }
    }
}
