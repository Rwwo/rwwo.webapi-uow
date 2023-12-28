namespace rwwo.webapi_uow.core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }

        int Save();
    }

}
