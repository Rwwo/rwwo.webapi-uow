using rwwo.webapi_uow.core.Interfaces;
using rwwo.webapi_uow.core.Models;

namespace rwwo.webapi_uow.infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<ProductDetails>, IProductRepository
    {
        public ProductRepository(DbContextClass dbContext) : base(dbContext)
        {

        }
    }
}
