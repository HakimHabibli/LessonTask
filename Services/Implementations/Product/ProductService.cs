using ProductAPI.DAL;
using ProductAPI.Services.Implementations.Base;

namespace ProductAPI.Services.Implementations.Product
{
    public class ProductService : BaseService<Models.Product>
    {
        public ProductService(AppDbContext context) : base(context)
        {
        }
    }
}
