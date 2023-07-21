namespace ShopUI.Models
{
    public class EfProductRepository : IProductRepository
    {
        private readonly StoreDbContext storeDbContext;

        public EfProductRepository(StoreDbContext storeDbContext)
        {
            this.storeDbContext = storeDbContext;
        }
        public PageData<Product> GetAll(int pageNumber, int pageSize)
        {
            var result = new PageData<Product>
            {
                PageInfo = new PageInfo
                {
                    PageSize = pageSize,
                    PageNumber = pageNumber
                }
            };

            result.Data = storeDbContext.Products.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            result.PageInfo.TotalCount = storeDbContext.Products.Count();
            var test = storeDbContext.Products.Count();
            return result;      
        }
    }
}
 