using System.ComponentModel.DataAnnotations;

namespace WebTest.Models.BD
{
    public class Pricelist
    {
        public Pricelist()
        {
        }

        public Pricelist(string name, int idOnlystring)
        {
            Name = name;
            IdOnlystring = idOnlystring;
        }

        [Key]
        public int IdPriceList { get; set; }
        public string Name { get; set; }
        public int IdOnlystring { get; set; }
    }
}
