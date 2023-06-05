using ProductAPI.DAL;
using ProductAPI.Services.Implementations.Base;

namespace ProductAPI.Services.Implementations.Restaurant
{
    public class RestaurantService : BaseService<Models.Restaurant>
    {
        public RestaurantService(AppDbContext context) : base(context)
        {
        }
    }
}
