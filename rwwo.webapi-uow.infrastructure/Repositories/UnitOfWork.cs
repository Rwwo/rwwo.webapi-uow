using rwwo.webapi_uow.core.Interfaces;

namespace rwwo.webapi_uow.infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContextClass _dbContext;
        public IProductRepository Products { get; }

        public UnitOfWork(DbContextClass dbContext,
                            IProductRepository productRepository)
        {
            _dbContext = dbContext;
            Products = productRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }

    }
}
