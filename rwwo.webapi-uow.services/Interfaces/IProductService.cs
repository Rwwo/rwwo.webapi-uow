using rwwo.webapi_uow.core.Models;

namespace rwwo.webapi_uow.services.Interfaces
{
    public interface IProductService
    {
        Task<bool> CreateProduct(ProductDetails productDetails);

        Task<IEnumerable<ProductDetails>> GetAllProducts();

        Task<ProductDetails> GetProductById(int productId);

        Task<bool> UpdateProduct(ProductDetails productDetails);

        Task<bool> DeleteProduct(int productId);
    }
}
