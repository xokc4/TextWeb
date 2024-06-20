namespace WebTest.ViewModels
{
    public class AddPriceListModel
    {

        public string ListName { get; set; }
        public List<string> Rows { get; set; } = new List<string>();
    }

}
