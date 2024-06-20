using System.ComponentModel.DataAnnotations;

namespace WebTest.Models.BD
{
    public class Element
    {
        public Element()
        {
        }

        public Element(int idOnlystring, string nameProduct, int indexProduct, int idOne)
        {
            IdOnlystring = idOnlystring;
            NameProduct = nameProduct;
            IndexProduct = indexProduct;
            IdOne = idOne;
        }

        [Key]
        public int IdElement { get; set; }
        public int IdOnlystring { get; set; }
        public string NameProduct { get; set; }
        public int IndexProduct { get; set; }
        public int IdOne { get; set; }
    }
}
