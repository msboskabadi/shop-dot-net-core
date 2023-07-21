namespace ShopUI.Models
{
    public class ProductListViewModel
    {
        public PageData<Product> Data { get; set; }
        public string currentCategory { get; set; }
    }
}
