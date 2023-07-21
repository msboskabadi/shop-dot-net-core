namespace ShopUI.Models
{
    public interface IProductRepository
    {
        PageData<Product> GetAll(int pageNumber, int pageSize, string category);
        List<string> GetAllCategories();
    }
}
