namespace ShopUI.Models
{
    public interface IProductRepository
    {
        PageData<Product> GetAll(int pageSize, int pageNumber);
    }
}
